#!/usr/bin/env bash

if [ "$APPCENTER_BRANCH" == "master" ];
then
	cd 
	cp $APPCENTER_SOURCE_DIRECTORY/AppCenterConfiguration_sample.txt $APPCENTER_SOURCE_DIRECTORY/AppCenterConfiguration.cs
	sed -i -e "s/<your android app id>/$ANDROID_ID/g" $APPCENTER_SOURCE_DIRECTORY/AppCenterConfiguration.cs
	sed -i -e "s/<your ios app id>/$IOS_ID/g" $APPCENTER_SOURCE_DIRECTORY/AppCenterConfiguration.cs
fi