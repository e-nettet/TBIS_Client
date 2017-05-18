@echo off
xsd.exe frestgaeld6.xsd /classes /namespace:FRestgaeld6
xsd.exe srestgaeld63.xsd /classes /namespace:SRestgaeld63
xsd.exe fegne6.xsd /classes /namespace:FEgne6
xsd.exe segne6.xsd /classes /namespace:SEgne6
xsd.exe falle6.xsd /classes /namespace:FAlle6
xsd.exe salle6.xsd /classes /namespace:SAlle6
xsd.exe fpriser6.xsd /classes /namespace:FPriser6
xsd.exe spriser6.xsd /classes /namespace:SPriser6
xsd.exe fsatser6.xsd /classes /namespace:FSatser6
xsd.exe ssatser6.xsd /classes /namespace:SSatser6
xsd.exe FOmregningstabeller6.xsd /classes /namespace:FOmregningstabeller6
xsd.exe SOmregningstabeller6.xsd /classes /namespace:SOmregningstabeller6

copy frestgaeld6.cs ..\TBIS_Client\frestgaeld6.cs /Y 
copy srestgaeld.cs ..\TBIS_Client\srestgaeld.cs /Y
copy fegne6.cs ..\TBIS_Client\fegne6.cs /Y 
copy segne6.cs ..\TBIS_Client\segne6.cs /Y
copy falle6.cs ..\TBIS_Client\falle6.cs /Y 
copy salle6.cs ..\TBIS_Client\salle6.cs /Y
copy fpriser6.cs ..\TBIS_Client\fpriser6.cs /Y 
copy spriser6.cs ..\TBIS_Client\spriser6.cs /Y
copy fsatser6.cs ..\TBIS_Client\fsatser6.cs /Y 
copy ssatser6.cs ..\TBIS_Client\ssatser6.cs /Y
copy FOmregningstabeller6.cs ..\TBIS_Client\FOmregningstabeller6.cs /Y
copy SOmregningstabeller6.cs ..\TBIS_Client\SOmregningstabeller6.cs /Y