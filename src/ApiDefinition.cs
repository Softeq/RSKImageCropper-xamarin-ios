using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using UIKit;
using CoreGraphics;
using System;

namespace Softeq.RSKImageCropper
{
    // @interface RSKImageCropViewController
    [BaseType(typeof(UIViewController))]
    [Protocol]
    interface RSKImageCropViewController
    {
        // -(instancetype)initWithImage:(id)originalImage;
        [Export("initWithImage:")]
        IntPtr Constructor(UIImage originalImage);

        // -(instancetype)initWithImage:(id)originalImage cropMode:(id)cropMode;
        [Export("initWithImage:cropMode:")]
        IntPtr Constructor(UIImage originalImage, RSKImageCropMode cropMode);

        // -(void)zoomToRect:(id)rect animated:(id)animated;
        [Export("zoomToRect:animated:")]
        void ZoomToRect(CGRect rect, bool animated);

        [Wrap("WeakDelegate")]
        [NullAllowed]
        RSKImageCropViewControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<RSKImageCropViewControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        [Wrap("WeakDataSource")]
        [NullAllowed]
        RSKImageCropViewControllerDataSource DataSource { get; set; }

        // @property (nonatomic, weak) id<RSKImageCropViewControllerDataSource> _Nullable dataSource;
        [NullAllowed, Export("dataSource", ArgumentSemantic.Weak)]
        NSObject WeakDataSource { get; set; }

        // @property (nonatomic, strong) int * originalImage;
        [Export("originalImage", ArgumentSemantic.Strong)]
        UIImage OriginalImage { get; set; }

        // @property (copy, nonatomic) int * maskLayerColor;
        [Export("maskLayerColor", ArgumentSemantic.Copy)]
        UIColor MaskLayerColor { get; set; }

        // @property (assign, nonatomic) int maskLayerLineWidth;
        [Export("maskLayerLineWidth")]
        nfloat MaskLayerLineWidth { get; set; }

        // @property (copy, nonatomic) int * _Nullable maskLayerStrokeColor;
        [NullAllowed, Export("maskLayerStrokeColor", ArgumentSemantic.Copy)]
        UIColor MaskLayerStrokeColor { get; set; }

        // @property (readonly, assign, nonatomic) int maskRect;
        [Export("maskRect")]
        CGRect MaskRect { get; }

        // @property (readonly, copy, nonatomic) int * maskPath;
        [Export("maskPath", ArgumentSemantic.Copy)]
        UIBezierPath MaskPath { get; }

        // @property (assign, nonatomic) int cropMode;
        [Export("cropMode")]
        RSKImageCropMode CropMode { get; set; }

        // @property (readonly, nonatomic) int cropRect;
        [Export("cropRect")]
        CGRect CropRect { get; }

        // @property (readonly, nonatomic) int rotationAngle;
        [Export("rotationAngle")]
        nfloat RotationAngle { get; }

        // @property (readonly, nonatomic) int zoomScale;
        [Export("zoomScale")]
        nfloat ZoomScale { get; }

        // @property (assign, nonatomic) int avoidEmptySpaceAroundImage;
        [Export("avoidEmptySpaceAroundImage")]
        bool AvoidEmptySpaceAroundImage { get; set; }

        // @property (assign, nonatomic) int alwaysBounceHorizontal;
        [Export("alwaysBounceHorizontal")]
        bool AlwaysBounceHorizontal { get; set; }

        // @property (assign, nonatomic) int alwaysBounceVertical;
        [Export("alwaysBounceVertical")]
        int AlwaysBounceVertical { get; set; }

        // @property (assign, nonatomic) int applyMaskToCroppedImage;
        [Export("applyMaskToCroppedImage")]
        bool ApplyMaskToCroppedImage { get; set; }

        // @property (assign, nonatomic) int bounces;
        [Export("bounces")]
        bool Bounces { get; set; }

        // @property (assign, nonatomic) int bouncesZoom;
        [Export("bouncesZoom")]
        bool BouncesZoom { get; set; }

        // @property (getter = isRotationEnabled, assign, nonatomic) int rotationEnabled;
        [Export("rotationEnabled")]
        bool RotationEnabled { [Bind("isRotationEnabled")] get; set; }

        // @property (readonly, nonatomic, strong) int * moveAndScaleLabel;
        [Export("moveAndScaleLabel", ArgumentSemantic.Strong)]
        UILabel MoveAndScaleLabel { get; }

        // @property (readonly, nonatomic, strong) int * cancelButton;
        [Export("cancelButton", ArgumentSemantic.Strong)]
        UIButton CancelButton { get; }

        // @property (readonly, nonatomic, strong) int * chooseButton;
        [Export("chooseButton", ArgumentSemantic.Strong)]
        UIButton ChooseButton { get; }

        // -(id)isPortraitInterfaceOrientation;
        [Export("isPortraitInterfaceOrientation")]
        bool IsPortraitInterfaceOrientation { get; }

        // @property (assign, nonatomic) int portraitCircleMaskRectInnerEdgeInset;
        [Export("portraitCircleMaskRectInnerEdgeInset")]
        nfloat PortraitCircleMaskRectInnerEdgeInset { get; set; }

        // @property (assign, nonatomic) int portraitSquareMaskRectInnerEdgeInset;
        [Export("portraitSquareMaskRectInnerEdgeInset")]
        nfloat PortraitSquareMaskRectInnerEdgeInset { get; set; }

        // @property (assign, nonatomic) int portraitMoveAndScaleLabelTopAndCropViewSafeAreaTopVerticalSpace;
        [Export("portraitMoveAndScaleLabelTopAndCropViewSafeAreaTopVerticalSpace")]
        nfloat PortraitMoveAndScaleLabelTopAndCropViewSafeAreaTopVerticalSpace { get; set; }

        // @property (assign, nonatomic) int portraitCropViewSafeAreaBottomAndCancelButtonBottomVerticalSpace;
        [Export("portraitCropViewSafeAreaBottomAndCancelButtonBottomVerticalSpace")]
        nfloat PortraitCropViewSafeAreaBottomAndCancelButtonBottomVerticalSpace { get; set; }

        // @property (assign, nonatomic) int portraitCropViewSafeAreaBottomAndChooseButtonBottomVerticalSpace;
        [Export("portraitCropViewSafeAreaBottomAndChooseButtonBottomVerticalSpace")]
        nfloat PortraitCropViewSafeAreaBottomAndChooseButtonBottomVerticalSpace { get; set; }

        // @property (assign, nonatomic) int portraitCancelButtonLeadingAndCropViewSafeAreaLeadingHorizontalSpace;
        [Export("portraitCancelButtonLeadingAndCropViewSafeAreaLeadingHorizontalSpace")]
        nfloat PortraitCancelButtonLeadingAndCropViewSafeAreaLeadingHorizontalSpace { get; set; }

        // @property (assign, nonatomic) int portraitCropViewSafeAreaTrailingAndChooseButtonTrailingHorizontalSpace;
        [Export("portraitCropViewSafeAreaTrailingAndChooseButtonTrailingHorizontalSpace")]
        nfloat PortraitCropViewSafeAreaTrailingAndChooseButtonTrailingHorizontalSpace { get; set; }

        // @property (assign, nonatomic) int landscapeCircleMaskRectInnerEdgeInset;
        [Export("landscapeCircleMaskRectInnerEdgeInset")]
        nfloat LandscapeCircleMaskRectInnerEdgeInset { get; set; }

        // @property (assign, nonatomic) int landscapeSquareMaskRectInnerEdgeInset;
        [Export("landscapeSquareMaskRectInnerEdgeInset")]
        nfloat LandscapeSquareMaskRectInnerEdgeInset { get; set; }

        // @property (assign, nonatomic) int landscapeMoveAndScaleLabelTopAndCropViewSafeAreaTopVerticalSpace;
        [Export("landscapeMoveAndScaleLabelTopAndCropViewSafeAreaTopVerticalSpace")]
        nfloat LandscapeMoveAndScaleLabelTopAndCropViewSafeAreaTopVerticalSpace { get; set; }

        // @property (assign, nonatomic) int landscapeCropViewSafeAreaBottomAndCancelButtonBottomVerticalSpace;
        [Export("landscapeCropViewSafeAreaBottomAndCancelButtonBottomVerticalSpace")]
        nfloat LandscapeCropViewSafeAreaBottomAndCancelButtonBottomVerticalSpace { get; set; }

        // @property (assign, nonatomic) int landscapeCropViewSafeAreaBottomAndChooseButtonBottomVerticalSpace;
        [Export("landscapeCropViewSafeAreaBottomAndChooseButtonBottomVerticalSpace")]
        nfloat LandscapeCropViewSafeAreaBottomAndChooseButtonBottomVerticalSpace { get; set; }

        // @property (assign, nonatomic) int landscapeCancelButtonLeadingAndCropViewSafeAreaLeadingHorizontalSpace;
        [Export("landscapeCancelButtonLeadingAndCropViewSafeAreaLeadingHorizontalSpace")]
        nfloat LandscapeCancelButtonLeadingAndCropViewSafeAreaLeadingHorizontalSpace { get; set; }

        // @property (assign, nonatomic) int landscapeCropViewSafeAreaTrailingAndChooseButtonTrailingHorizontalSpace;
        [Export("landscapeCropViewSafeAreaTrailingAndChooseButtonTrailingHorizontalSpace")]
        nfloat LandscapeCropViewSafeAreaTrailingAndChooseButtonTrailingHorizontalSpace { get; set; }
    }

    // @protocol RSKImageCropViewControllerDataSource
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface RSKImageCropViewControllerDataSource
    {
        // @required -(id)imageCropViewControllerCustomMaskRect:(RSKImageCropViewController *)controller;
        [Abstract]
        [Export("imageCropViewControllerCustomMaskRect:")]
        CGRect ImageCropViewControllerCustomMaskRect(RSKImageCropViewController controller);

        // @required -(id)imageCropViewControllerCustomMaskPath:(RSKImageCropViewController *)controller;
        [Abstract]
        [Export("imageCropViewControllerCustomMaskPath:")]
        UIBezierPath ImageCropViewControllerCustomMaskPath(RSKImageCropViewController controller);

        // @required -(id)imageCropViewControllerCustomMovementRect:(RSKImageCropViewController *)controller;
        [Abstract]
        [Export("imageCropViewControllerCustomMovementRect:")]
        CGRect ImageCropViewControllerCustomMovementRect(RSKImageCropViewController controller);
    }

    // @protocol RSKImageCropViewControllerDelegate
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface RSKImageCropViewControllerDelegate
    {
        // @required -(void)imageCropViewControllerDidCancelCrop:(RSKImageCropViewController *)controller;
        [Abstract]
        [Export("imageCropViewControllerDidCancelCrop:")]
        void ImageCropViewControllerDidCancelCrop(RSKImageCropViewController controller);

        // @required -(void)imageCropViewController:(RSKImageCropViewController *)controller didCropImage:(id)croppedImage usingCropRect:(id)cropRect rotationAngle:(id)rotationAngle;
        [Abstract]
        [Export("imageCropViewController:didCropImage:usingCropRect:rotationAngle:")]
        void ImageCropViewController(RSKImageCropViewController controller, UIImage croppedImage, CGRect cropRect, nfloat rotationAngle);

        // @optional -(void)imageCropViewControllerDidDisplayImage:(RSKImageCropViewController *)controller;
        [Export("imageCropViewControllerDidDisplayImage:")]
        void ImageCropViewControllerDidDisplayImage(RSKImageCropViewController controller);

        // @optional -(void)imageCropViewController:(RSKImageCropViewController *)controller willCropImage:(id)originalImage;
        [Export("imageCropViewController:willCropImage:")]
        void ImageCropViewController(RSKImageCropViewController controller, UIImage originalImage);
    }

    // @interface RSKImageCropViewControllerProtectedMethods
    [Category]
    [BaseType(typeof(RSKImageCropViewController))]
    interface RSKImageCropViewControllerProtectedMethods
    {
        // -(void)cropImage;
        [Export("cropImage")]
        void CropImage();

        // -(void)cancelCrop;
        [Export("cancelCrop")]
        void CancelCrop();

        // -(void)reset:(id)animated;
        [Export("reset:")]
        void Reset(bool animated);

        // -(void)setRotationAngle:(id)rotationAngle;
        [Export("setRotationAngle:")]
        void SetRotationAngle(nfloat rotationAngle);

        // -(void)setZoomScale:(id)zoomScale;
        [Export("setZoomScale:")]
        void SetZoomScale(nfloat zoomScale);
    }

    // @interface RSKImageScrollView
    [BaseType(typeof(UIScrollView))]
    interface RSKImageScrollView
    {
        [Wrap("WeakImageScrollViewDelegate")]
        [NullAllowed]
        RSKImageScrollViewDelegate ImageScrollViewDelegate { get; set; }

        // @property (nonatomic, weak) id<RSKImageScrollViewDelegate> _Nullable imageScrollViewDelegate;
        [NullAllowed, Export("imageScrollViewDelegate", ArgumentSemantic.Weak)]
        NSObject WeakImageScrollViewDelegate { get; set; }

        // @property (nonatomic, strong) int * _Nullable zoomView;
        [NullAllowed, Export("zoomView", ArgumentSemantic.Strong)]
        UIImageView ZoomView { get; set; }

        // @property (assign, nonatomic) int aspectFill;
        [Export("aspectFill")]
        bool AspectFill { get; set; }

        // -(void)displayImage:(id)image;
        [Export("displayImage:")]
        void DisplayImage(NSObject image);
    }

    // @protocol RSKImageScrollViewDelegate
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface RSKImageScrollViewDelegate
    {
        // @required -(void)imageScrollViewWillBeginDragging;
        [Abstract]
        [Export("imageScrollViewWillBeginDragging")]
        void ImageScrollViewWillBeginDragging();

        // @required -(void)imageScrollViewDidEndDragging:(id)willDecelerate;
        [Abstract]
        [Export("imageScrollViewDidEndDragging:")]
        void ImageScrollViewDidEndDragging(NSObject willDecelerate);

        // @required -(void)imageScrollViewDidEndDecelerating;
        [Abstract]
        [Export("imageScrollViewDidEndDecelerating")]
        void ImageScrollViewDidEndDecelerating();

        // @required -(void)imageScrollViewWillBeginZooming;
        [Abstract]
        [Export("imageScrollViewWillBeginZooming")]
        void ImageScrollViewWillBeginZooming();

        // @required -(void)imageScrollViewDidEndZooming;
        [Abstract]
        [Export("imageScrollViewDidEndZooming")]
        void ImageScrollViewDidEndZooming();
    }

    [BaseType(typeof(NSObject))]
    public interface RSKInternalUtility
    {
        // +(NSBundle *)bundleForStrings;
        [Static]
        [Export("bundleForStrings")]
        NSBundle BundleForStrings { get; }
    }

    [BaseType(typeof(UIView))]
    public interface RSKTouchView
    {
        // @property (nonatomic, weak) UIView * receiver;
        [Export("receiver", ArgumentSemantic.Weak)]
        UIView Receiver { get; set; }
    }

    [Category]
    [BaseType(typeof(UIImage))]
    public interface UIImage_RSKImageCropper
    {
        // -(UIImage *)fixOrientation;
        [Export("fixOrientation")]
        [Static]
        UIImage FixOrientation { get; }

        // -(UIImage *)rotateByAngle:(CGFloat)angleInRadians;
        [Export("rotateByAngle:")]
        UIImage RotateByAngle(nfloat angleInRadians);
    }
}
