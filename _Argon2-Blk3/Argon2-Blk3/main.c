#include <stdio.h>
#include <stdlib.h>
#include <stdint.h>
#include <string.h>
#include <time.h>
#include <assert.h>

#include "blake3.h"
#include "test_functions.h"
#include "argon2.h"



__declspec(dllexport) int export_argon2_blake3(
    uint32_t t_cost,
    uint32_t m_cost,
    uint32_t parallelism,
    uint8_t* password,
    uint32_t password_len,
    uint8_t* salt,
    uint32_t salt_len,
    uint8_t* hash,
    uint32_t hash_len)
{
    int version = ARGON2_VERSION_10;

    return argon2_hash_without_encoding(t_cost, m_cost, parallelism, password, password_len, salt, salt_len, hash, hash_len, version, 3);
}

_declspec(dllexport) int export_test_argon2_blake3()
{
    if (test_blake_3() && argon2_test())
        return -1;
    return 0;
}