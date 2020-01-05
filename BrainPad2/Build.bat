call cd C:\netmf\netmf44VS2017\
call setenv_mdk 5.06
call cd C:\netmf\netmf44VS2017\Solutions\BrainPad2
msbuild /t:build /p:flavor=release;memory=flash
call %SystemRoot%\explorer.exe "C:\netmf\netmf44VS2017\BuildOutput\THUMB2FP\MDK5.06\le\FLASH\release\BrainPad2\bin" 