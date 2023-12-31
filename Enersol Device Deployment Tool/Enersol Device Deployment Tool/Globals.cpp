#include "Globals.h"

namespace Globals
{
	Device _S77 = { S77,		ARDUNO,		ARDUNOMIC,		ARDUNOPROG };
	Device _S77A = { S77A,		ARDUNO,		ARDUNOMIC,		ARDUNOPROG };
	Device _S77B = { S77B,		ARDUNO,		ARDUNOMIC,		ARDUNOPROG };
	Device _S78 = { S78 ,		ARDUNO,		ARDUNOMIC,		ARDUNOPROG };
	Device _S78A = { S78A,		ARDUNO,		ARDUNOMIC,		ARDUNOPROG };
	Device _S78B = { S78B,		ARDUNO,		ARDUNOMIC,		ARDUNOPROG };
	Device _S79 = { S79 ,		ARDUNO,		ARDUNOMIC,		ARDUNOPROG };
	Device _VLT = { VLT ,		ARDUNO,		ARDUNOMIC,		ARDUNOPROG };
	Device _AWPSIT = { AWPSIT ,	ARDUNO,		ARDUNOMIC,		ARDUNOPROG };
	Device _ELTP = { ELTP ,		ARDMEGA,	ARDMEGAMIC,		ARDMEGAPROG };
	Device _S18C = { S18C ,		ARDNANOEVE, ARDNANOEVEMIC,	ARDNANOEVEPROG };

	Device* Devices[deviceNumber] = { &_S77, &_S77A, &_S77B, &_S78, &_S78A,&_S78B, &_S79, &_VLT, &_AWPSIT, &_ELTP, &_S18C };

}