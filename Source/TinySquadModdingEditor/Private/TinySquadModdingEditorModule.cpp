// Copyright Epic Games, Inc. All Rights Reserved.

/**
 *
 *  _____ _          ___                    _
 * |_   _(_)_ _ _  _/ __| __ _ _  _ __ _ __| |
 *   | | | | ' \ || \__ \/ _` | || / _` / _` |
 *   |_| |_|_||_\_, |___/\__, |\_,_\__,_\__,_|
 *              |__/        |_|
 *
 * @date : 27-07-2025
 * @author : ALVES Quentin
 *
 **/

#include "TinySquadModdingEditorModule.h"

#define LOCTEXT_NAMESPACE "FTinySquadModdingEditorModule"

////////////////////////////////////////////////////////////////////////////////////////////
//		===	PUBLIC ===
////////////////////////////////////////////////////////////////////////////////////////////
void FTinySquadModdingEditorModule::StartupModule( ) {
}

void FTinySquadModdingEditorModule::ShutdownModule( ) {
}

#undef LOCTEXT_NAMESPACE

IMPLEMENT_MODULE( FTinySquadModdingEditorModule, TinySquadModdingEditor )
