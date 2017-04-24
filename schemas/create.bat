@echo off
xsd.exe frestgaeld.xsd /classes /namespace:FRestgaeld6
xsd.exe srestgaeld.xsd /classes /namespace:SRestgaeld63
xsd.exe FOmregningstabeller6.xsd /classes /namespace:FOmregningstabeller6
xsd.exe SOmregningstabeller6.xsd /classes /namespace:SOmregningstabeller6

copy frestgaeld.cs ..\TBIS_Client\frestgaeld.cs /Y 
copy srestgaeld.cs ..\TBIS_Client\srestgaeld.cs /Y
copy FOmregningstabeller6.cs ..\TBIS_Client\FOmregningstabeller6.cs /Y
copy SOmregningstabeller6.cs ..\TBIS_Client\SOmregningstabeller6.cs /Y