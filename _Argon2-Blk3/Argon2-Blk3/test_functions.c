#include <stdio.h>
#include <stdlib.h>
#include <stdint.h>
#include <string.h>
#include <time.h>
#include <assert.h>

#include "test_functions.h"
#include "argon2.h"
#include "blake3.h"

#define OUT_LEN 32
#define ENCODED_LEN 108

unsigned char* byte_array_to_char_array(unsigned char* input, int length)
{
    int i = 0;
    if(length <= 0)
        return NULL;
    unsigned char* output = (unsigned char*)calloc(2 * length, sizeof(unsigned char));
    int ctr = 0;
    int x;
    for(int i = 0; i < length; i++)
    {
        x = input[i] >> 4;
        if(x < 10)
            output[ctr] = x + 48;
        else
            output[ctr] = x + 87;

        ctr += 1;

        x = input[i] % 16;
        if(x < 10)
            output[ctr] = x + 48;
        else
            output[ctr] = x + 87;


        ctr += 1;

    }

    return output;
}

int test_blake_3()
{

    unsigned char *buf = (unsigned char*)calloc(102400, sizeof(unsigned char));
    for(int i = 0; i < 102400; i++)
        buf[i] = i % 251;

    uint8_t output[BLAKE3_OUT_LEN * 2];
    char* char_output = (char*)calloc(BLAKE3_OUT_LEN * 4, sizeof(char));

    int lengths_array[36] = {0, 1, 2, 3, 4, 5, 6, 7, 8, 63, 64, 65, 127, 128, 129, 1023, 1024, 1025, 2048, 2049, 3072, 3073, 4096, 4097, 5120, 5121, 6144, 6145, 7168, 7169, 8192, 8193, 16384, 31744, 102400};

    blake3_hasher hasher;

    FILE* filePointer = fopen("test_vectors_blake3.txt", "r");
    if (filePointer == NULL)
        return -1;

    char buffer[264];

    int ok = 1;

    for(int i = 0; i < 35; i++){
        fscanf(filePointer, "%s", buffer);

        blake3_hasher_init(&hasher);
        blake3_hasher_update(&hasher, buf, lengths_array[i]);
        blake3_hasher_finalize(&hasher, output, BLAKE3_OUT_LEN * 2);

        char_output = byte_array_to_char_array(output, BLAKE3_OUT_LEN * 2);
        if (char_output == NULL)
            return -1;
        for(int j = 0; j < BLAKE3_OUT_LEN * 4; j++)
            if(buffer[j] != char_output[j])
                ok = 0;

        if (ok == 0)
            return -1;


    }

    free(buf);
    free(char_output);
    fclose(filePointer);
    return 0;
}


int hashtest(uint32_t version, uint32_t t, uint32_t m, uint32_t p, char *pwd,
              char *salt, char *hexref, char *mcfref) {
    unsigned char out[OUT_LEN];
    unsigned char hex_out[OUT_LEN * 2 + 4];
    char encoded[ENCODED_LEN];
    int i;

    if (argon2_hash(t, 1 << m, p, pwd, strlen(pwd), salt, strlen(salt), out, OUT_LEN, encoded, ENCODED_LEN, version))
        return -1;
    for (i = 0; i < OUT_LEN; ++i)
        sprintf((char *)(hex_out + i * 2), "%02x", out[i]);
    if (memcmp(hex_out, hexref, OUT_LEN * 2))
        return -1;


    if ((ARGON2_VERSION_NUMBER == version) && (memcmp(encoded, mcfref, strlen(mcfref))))
        return -1;

    if ((argon2_verify(encoded, pwd, strlen(pwd))) && argon2_verify(mcfref, pwd, strlen(pwd)))
        return -1;
    return 0;
}


int argon2_test()
{

    int version;

    version = ARGON2_VERSION_10;

    /* Multiple test cases for various input values */
    if (hashtest(version, 2, 16, 1, "password", "somesalt",
        "f6c4db4a54e2a370627aff3db6176b94a2a209a62c8e36152711802f7b30c694",
        "$argon2i$m=65536,t=2,p=1$c29tZXNhbHQ"
        "$9sTbSlTio3Biev89thdrlKKiCaYsjjYVJxGAL3swxpQ"))
        return -1;
#ifdef TEST_LARGE_RAM
    hashtest(version, 2, 20, 1, "password", "somesalt",
        "9690ec55d28d3ed32562f2e73ea62b02b018757643a2ae6e79528459de8106e9",
        "$argon2i$m=1048576,t=2,p=1$c29tZXNhbHQ"
        "$lpDsVdKNPtMlYvLnPqYrArAYdXZDoq5ueVKEWd6BBuk", Argon2_i);
#endif

	if (hashtest(version, 2, 18, 1, "password", "somesalt",
		"3e689aaa3d28a77cf2bc72a51ac53166761751182f1ee292e3f677a7da4c2467",
		"$argon2i$m=262144,t=2,p=1$c29tZXNhbHQ"
		"$Pmiaqj0op3zyvHKlGsUxZnYXURgvHuKS4/Z3p9pMJGc"))
		return -1;
    if (hashtest(version, 2, 8, 1, "password", "somesalt",
        "fd4dd83d762c49bdeaf57c47bdcd0c2f1babf863fdeb490df63ede9975fccf06",
        "$argon2i$m=256,t=2,p=1$c29tZXNhbHQ"
        "$/U3YPXYsSb3q9XxHvc0MLxur+GP960kN9j7emXX8zwY"))
        return -1;
    if(hashtest(version, 2, 8, 2, "password", "somesalt",
             "b6c11560a6a9d61eac706b79a2f97d68b4463aa3ad87e00c07e2b01e90c564fb",
             "$argon2i$m=256,t=2,p=2$c29tZXNhbHQ"
             "$tsEVYKap1h6scGt5ovl9aLRGOqOth+AMB+KwHpDFZPs"))
        return -1;
    if(hashtest(version, 1, 16, 1, "password", "somesalt",
             "81630552b8f3b1f48cdb1992c4c678643d490b2b5eb4ff6c4b3438b5621724b2",
             "$argon2i$m=65536,t=1,p=1$c29tZXNhbHQ"
             "$gWMFUrjzsfSM2xmSxMZ4ZD1JCytetP9sSzQ4tWIXJLI"))
        return -1;
    if(hashtest(version, 4, 16, 1, "password", "somesalt",
             "f212f01615e6eb5d74734dc3ef40ade2d51d052468d8c69440a3a1f2c1c2847b",
             "$argon2i$m=65536,t=4,p=1$c29tZXNhbHQ"
             "$8hLwFhXm6110c03D70Ct4tUdBSRo2MaUQKOh8sHChHs"))
        return -1;
    if(hashtest(version, 2, 16, 1, "differentpassword", "somesalt",
             "e9c902074b6754531a3a0be519e5baf404b30ce69b3f01ac3bf21229960109a3",
             "$argon2i$m=65536,t=2,p=1$c29tZXNhbHQ"
             "$6ckCB0tnVFMaOgvlGeW69ASzDOabPwGsO/ISKZYBCaM"))
        return -1;
    if (hashtest(version, 2, 16, 1, "password", "diffsalt",
        "79a103b90fe8aef8570cb31fc8b22259778916f8336b7bdac3892569d4f1c497",
        "$argon2i$m=65536,t=2,p=1$ZGlmZnNhbHQ"
        "$eaEDuQ/orvhXDLMfyLIiWXeJFvgza3vaw4kladTxxJc"))
        return -1;

    return 0;
}

























