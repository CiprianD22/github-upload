#include <stdlib.h>

__declspec(dllexport) void freeNonManage(void* bloc)
{
	free(bloc);
}