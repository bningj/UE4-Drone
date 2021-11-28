// Copyright Epic Games, Inc. All Rights Reserved.

#include "my1127GameMode.h"
#include "my1127Pawn.h"

Amy1127GameMode::Amy1127GameMode()
{
	// set default pawn class to our flying pawn
	DefaultPawnClass = Amy1127Pawn::StaticClass();
}
