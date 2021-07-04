#include <intrin.h>
#include <memory.h>
#include <stdint.h>


#ifdef _WIN64
#define RDRAND_CALLTYPE __fastcall
#else
#define RDRAND_CALLTYPE __stdcall
#endif

// defineste OP CODE-ul instructiunii rdrand si salvarea rezultatului ei in EAX, conform documentatiei INTEL
#define rdrand_eax	__asm _emit 0x0F __asm _emit 0xC7 __asm _emit 0xF0

void RDRAND_CALLTYPE rdrand(__deref_out uint8_t* dest) {

	__asm {
		xor eax, eax;
		xor edx, edx;

		rdrand_eax; //executa inline instructiunile definite in rdrand_eax si salveaza in EAX rezultatul

		mov edx, dest; //pune pointer-ul @param dest in EDX
		mov[edx], al; //pune byte-ul random din AL la adresa la care pointeaza @param dest
	}
}

_declspec(dllexport) int export_rdrand(uint8_t* salt, uint32_t length) {
	for (size_t i = 0; i < length; i++)
	{
		rdrand(&(salt[i]));
	}
	return 101;
}