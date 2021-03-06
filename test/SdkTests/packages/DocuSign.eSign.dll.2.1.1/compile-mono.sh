#!/usr/bin/env bash
wget -nc https://nuget.org/nuget.exe;
mozroots --import --sync
mono nuget.exe install vendor/packages.config -o vendor;
mkdir -p bin;
mcs -sdk:45 -r:vendor/Newtonsoft.Json.8.0.2/lib/net45/Newtonsoft.Json.dll,\
vendor/RestSharp.105.2.3/lib/net45/RestSharp.dll,\
System.Runtime.Serialization.dll \
-target:library \
-out:bin/DocuSign.eSign.dll \
-recurse:'src/*.cs' \
-doc:bin/DocuSign.eSign.xml \
-platform:anycpu
