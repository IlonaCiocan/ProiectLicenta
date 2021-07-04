#include <stdio.h>
#include <stdlib.h>
#include "aes.h"
#include "aes-gcm.h"

#define DLLExport __declspec(dllexport)

DLLExport int export_aes_gcm_encrypt(
        const uchar* key,       // pointer to the cipher key
        size_t key_len,         // byte length of the key
        const uchar* iv,        // pointer to the initialization vector
        size_t iv_len,          // byte length of the initialization vector
        const uchar* pt,        // pointer to the plaintext SOURCE data
        uchar* ct,        // pointer to the CORRECT cipher data
        size_t ct_len,          // byte length of the cipher data
        uchar* tag,       // pointer to the CORRECT tag to be generated
        size_t tag_len){        // byte length of the tag to be generated

    gcm_initialize();
    gcm_context ctx;
    gcm_setkey(&ctx, key, key_len);
    const uchar aad[16] = { 0xff, 0x76, 0x28, 0xf6, 0x42, 0x7f, 0xbc, 0xef, 0x1f, 0x3b, 0x82, 0xb3, 0x74, 0x04, 0xe1, 0x16 };
    size_t aad_len = 16;
    int ret = gcm_crypt_and_tag(&ctx, ENCRYPT, iv, iv_len, aad, aad_len, pt, ct, ct_len, tag, tag_len);

    gcm_zero_ctx(&ctx);

    return ret;
}

DLLExport int export_aes_gcm_decrypt(
        const uchar* key,       // pointer to the cipher key
        size_t key_len,         // byte length of the key
        const uchar* iv,        // pointer to the initialization vector
        size_t iv_len,          // byte length of the initialization vector
        uchar* pt,        // pointer to the plaintext SOURCE data
        const uchar* ct,        // pointer to the CORRECT cipher data
        size_t ct_len,          // byte length of the cipher data
        const uchar* tag,       // pointer to the CORRECT tag to be generated
        size_t tag_len){        // byte length of the tag to be generated

    gcm_initialize();
    gcm_context ctx;
    gcm_setkey(&ctx, key, key_len);

    const uchar aad[16] = { 0xff, 0x76, 0x28, 0xf6, 0x42, 0x7f, 0xbc, 0xef, 0x1f, 0x3b, 0x82, 0xb3, 0x74, 0x04, 0xe1, 0x16 };
    size_t aad_len = 16;
    int ret = gcm_auth_decrypt(&ctx, iv, iv_len, aad, aad_len, ct, pt, ct_len, tag, tag_len);

    gcm_zero_ctx(&ctx);

    return ret;
}


DLLExport int export_test_aes_gcm()
{

    const uchar key[32] = { 0x7f, 0x71, 0x68, 0xa4, 0x06, 0xe7, 0xc1, 0xef, 0x0f, 0xd4, 0x7a, 0xc9, 0x22, 0xc5, 0xec, 0x5f, 0x65, 0x97, 0x65, 0xfb, 0x6a, 0xaa, 0x04, 0x8f, 0x70, 0x56, 0xf6, 0xc6, 0xb5, 0xd8, 0x51, 0x3d };
    size_t key_len = 32;

    const uchar iv[12] = { 0xb8, 0xb5, 0xe4, 0x07, 0xad, 0xc0, 0xe2, 0x93, 0xe3, 0xe7, 0xe9, 0x91 };
    size_t iv_len = 12;

    const uchar pt[7] = { 0xb7, 0x06, 0x19, 0x4b, 0xb0, 0xb1, 0x0c };
    size_t pt_len = 7;

    uchar* ct = (uchar*)malloc(sizeof(uchar) * 7);
    size_t ct_len = 7;

    uchar* tag = (uchar*)malloc(sizeof(uchar) * 16);
    memset(tag, 0, 16);
    size_t tag_len = 16;

    int ret_enc = export_aes_gcm_encrypt(key, key_len, iv, iv_len, pt, ct, ct_len, tag, tag_len);

    uchar* dec = (uchar*)malloc(sizeof(uchar) * 7);

    int ret_dec = export_aes_gcm_decrypt(key, key_len, iv, iv_len, dec, ct, ct_len, tag, tag_len);

    if (ret_enc || ret_dec)
        return -1;

    for (int i = 0; i < pt_len; i++)
        if (pt[i] != dec[i])
            return -1;

	return 0;
}