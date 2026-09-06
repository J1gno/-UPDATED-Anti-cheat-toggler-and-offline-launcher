@echo off
title Elden Ring Anti-Cheat Toggler
color 0B

if exist "start_protected_game-old.exe" (
    if exist "start_protected_game.exe" del "start_protected_game.exe"
    ren "start_protected_game-old.exe" "start_protected_game.exe"
    echo Mods DISABLED. Anti-Cheat ENABLED.
    echo You can now safely play online.
) else if exist "start_protected_game.exe" (
    if exist "eldenring.exe" (
        ren "start_protected_game.exe" "start_protected_game-old.exe"
        copy "eldenring.exe" "start_protected_game.exe"
        echo Mods ENABLED. Anti-Cheat DISABLED.
    ) else (
        echo ERROR: eldenring.exe not found!
    )
) else (
    echo ERROR: Required files not found! Make sure this is in your Game folder.
)

echo.
pause