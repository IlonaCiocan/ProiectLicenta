#include "argon2.h"
#include <stdio.h>
#include <string.h>
#include <stdlib.h>

__declspec(dllexport) int export_argon2_blake2(uint8_t* PWD, 
                                      uint32_t pwdlen,
                                      uint8_t* hash, 
                                      uint32_t* HASHLEN,
                                      uint8_t* salt,
                                      uint32_t SALTLEN,
                                      uint32_t t_cost,
                                      uint32_t m_cost,
                                      uint32_t parallelism
    )
{

    argon2_hash(t_cost, m_cost, parallelism, PWD, pwdlen, salt, SALTLEN, hash, HASHLEN, Argon2_i, ARGON2_VERSION_NUMBER);

    return 101;
}


__declspec(dllexport) int export_test_argon2_blake2()
{
    uint8_t* PWD = "password";
    uint32_t pwdlen = strlen("password");
    uint32_t* HASHLEN = (uint32_t*)malloc(sizeof(uint32_t));
    *HASHLEN = 32;
    uint8_t* hash = (uint8_t*)malloc(sizeof(uint8_t) * (*HASHLEN));
    uint8_t* salt = "somesalt";
    uint32_t SALTLEN = strlen("somesalt");
    uint32_t t_cost = 2;
    uint32_t m_cost = 1 << 16;
    uint32_t parallelism = 1;
    uint8_t expected_hash[32] = { 0xC1, 0x62, 0x88, 0x32, 0x14, 0x7D, 0x97, 0x20, 0xC5, 0xBD, 0x1C, 0xFD, 0x61, 0x36, 0x70, 0x78, 0x72, 0x9F, 0x6D, 0xFB, 0x6F, 0x8F, 0xEA, 0x9F, 0xF9, 0x81, 0x58, 0xE0, 0xD7, 0x81, 0x6E, 0xD0 };
    argon2_hash(t_cost, m_cost, parallelism, PWD, pwdlen, salt, SALTLEN, hash, *HASHLEN, Argon2_i, ARGON2_VERSION_NUMBER);
    for (int i = 0; i < *HASHLEN; i++)
        if (expected_hash[i] != hash[i])
            return -1;
    return 0;
}