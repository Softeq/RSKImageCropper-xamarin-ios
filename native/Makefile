XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=.
PROJECT=$(PROJECT_ROOT)/RSKImageCropper/RSKImageCropper.xcodeproj
TARGET=RSKImageCropper

.PHONY: archive clean build

archive: archive-iphone archive-iossimulator

archive-iphone:
	$(XBUILD) archive \
		-project $(PROJECT) \
		-scheme $(TARGET) \
		-destination "generic/platform=iOS" \
		-archivePath "$(PROJECT_ROOT)/archives/$(TARGET)-iOS.xcarchive" \
		SKIP_INSTALL=NO

archive-iossimulator:
	$(XBUILD) archive \
		-project $(PROJECT) \
		-scheme $(TARGET) \
		-destination "generic/platform=iOS Simulator" \
		-archivePath "$(PROJECT_ROOT)/archives/$(TARGET)-iOS_Simulator.xcarchive" \
		SKIP_INSTALL=NO

build: archive
	$(XBUILD) -create-xcframework \
		-archive $(PROJECT_ROOT)/archives/$(TARGET)-iOS.xcarchive -framework $(TARGET).framework \
		-archive $(PROJECT_ROOT)/archives/$(TARGET)-iOS_Simulator.xcarchive -framework $(TARGET).framework \
		-output $(PROJECT_ROOT)/$(TARGET).xcframework

clean:
	-rm -rf archives *.xcframework