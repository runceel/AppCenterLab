#!/usr/bin/env bash

if [ "$APPCENTER_BRANCH" == "master" ];
then
	cp AppCenterConfiguration_sample.txt AppCenterConfiguration.cs
	sed -i -e "s/<your android app id>/$ANDROID_ID/g" AppCenterConfiguration.cs
	sed -i -e "s/<your ios app id>/$IOS_ID/g" AppCenterConfiguration.cs
fi