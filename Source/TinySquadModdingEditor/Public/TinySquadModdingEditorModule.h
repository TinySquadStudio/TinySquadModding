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

#pragma once

#include "Modules/ModuleManager.h"

class TINYSQUADMODDINGEDITOR_API FTinySquadModdingEditorModule
	: public IModuleInterface 
{

public:
	virtual void StartupModule( ) override;

	virtual void ShutdownModule( ) override;

};
