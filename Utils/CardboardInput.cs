using UnityEngine.XR;

namespace Cardboard.Utils
{
    public class Input
    {
        /// <summary>
        /// Gets the value of the specified InputType.
        /// </summary>
        /// <param name="_inputType">The InputType of the button you want the value of.</param>
        /// <returns>A bool based on if the button is pressed.</returns>
        public static bool GetValue(InputType _inputType)
        {
            bool value = false;

            switch (_inputType)
            {
                case InputType.leftPrimary: InputDevices.GetDeviceAtXRNode(XRNode.LeftHand).TryGetFeatureValue(CommonUsages.primaryButton, out value); break;
                case InputType.leftSecondary: InputDevices.GetDeviceAtXRNode(XRNode.LeftHand).TryGetFeatureValue(CommonUsages.secondaryButton, out value); break;
                case InputType.leftTrigger: InputDevices.GetDeviceAtXRNode(XRNode.LeftHand).TryGetFeatureValue(CommonUsages.triggerButton, out value); break;
                case InputType.leftGrip: InputDevices.GetDeviceAtXRNode(XRNode.LeftHand).TryGetFeatureValue(CommonUsages.gripButton, out value); break;
                case InputType.leftStick: InputDevices.GetDeviceAtXRNode(XRNode.LeftHand).TryGetFeatureValue(CommonUsages.primary2DAxisClick, out value); break;

                case InputType.rightPrimary: InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetFeatureValue(CommonUsages.primaryButton, out value); break;
                case InputType.rightSecondary: InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetFeatureValue(CommonUsages.secondaryButton, out value); break;
                case InputType.rightTrigger: InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetFeatureValue(CommonUsages.triggerButton, out value); break;
                case InputType.rightGrip: InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetFeatureValue(CommonUsages.gripButton, out value); break;
                case InputType.rightStick: InputDevices.GetDeviceAtXRNode(XRNode.LeftHand).TryGetFeatureValue(CommonUsages.primary2DAxisClick, out value); break;
            }

            return value;
        }
    }
}