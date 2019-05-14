#!/usr/bin/env bash

if [ "$APPCENTER_BRANCH" == "master" ];
then
	cd 
	cp $APPCENTER_SOURCE_DIRECTORY/AppCenterLab/AppCenterLab/AppCenterConfiguration_sample.txt $APPCENTER_SOURCE_DIRECTORY/AppCenterLab/AppCenterLab/AppCenterConfiguration.cs
	sed -i -e "s/<your android app id>/$ANDROID_ID/g" $APPCENTER_SOURCE_DIRECTORY/AppCenterLab/AppCenterLab/AppCenterConfiguration.cs
	sed -i -e "s/<your ios app id>/$IOS_ID/g" $APPCENTER_SOURCE_DIRECTORY/AppCenterLab/AppCenterLab/AppCenterConfiguration.cs
fi