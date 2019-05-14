#!/usr/bin/env bash

if [ "$APPCENTER_BRANCH" == "master" ];
then
	cp AppCenterLab/AppCenterConfiguration_sample.txt AppCenterLab/AppCenterConfiguration.cs
	sed -i -e "s/<your android app id>/$ANDROID_ID/g" AppCenterLab/AppCenterConfiguration.cs
	sed -i -e "s/<your ios app id>/$IOS_ID/g" AppCenterLab/AppCenterConfiguration.cs
fi