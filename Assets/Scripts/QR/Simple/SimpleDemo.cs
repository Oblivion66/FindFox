using BarcodeScanner;
using BarcodeScanner.Scanner;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Wizcorp.Utils.Logger;

public class SimpleDemo : MonoBehaviour {

	private IScanner BarcodeScanner;
	public RawImage Image;
	public static string value = null;

	// Disable Screen Rotation on that screen
	void Awake()
	{
		Screen.autorotateToPortrait = false;
		Screen.autorotateToPortraitUpsideDown = false;
	}

	void Start () {
		// Create a basic scanner
		BarcodeScanner = new Scanner();
		BarcodeScanner.Camera.Play();

		// Display the camera texture through a RawImage
		BarcodeScanner.OnReady += (sender, arg) => {
			// Set Orientation & Texture
			Image.transform.localEulerAngles = BarcodeScanner.Camera.GetEulerAngles();
			Image.transform.localScale = BarcodeScanner.Camera.GetScale();
			Image.texture = BarcodeScanner.Camera.Texture;

			// Keep Image Aspect Ratio
			var rect = Image.GetComponent<RectTransform>();
			var newHeight = rect.sizeDelta.x * BarcodeScanner.Camera.Height / BarcodeScanner.Camera.Width;
			rect.sizeDelta = new Vector2(rect.sizeDelta.x, newHeight);
			Image.transform.Rotate(new Vector3(0, 0, -90));
		};
		Image.enabled = false;
		BarcodeScanner.Camera.Stop();
	}

	/// <summary>
	/// The Update method from unity need to be propagated to the scanner
	/// </summary>
	void Update()
	{
		if (BarcodeScanner == null)
		{
			return;
		}
		BarcodeScanner.Update();
	}

	#region UI Buttons

	public void Run()
	{
		if (!BarcodeScanner.Camera.IsPlaying())
        {
			BarcodeScanner.Camera.Play();
        }
		Image.enabled = true;

		// Start Scanning
		BarcodeScanner.Scan((barCodeType, barCodeValue) => {
			BarcodeScanner.Stop();
			value = barCodeValue;
			this.ClickStop();
		});
	}

	public void ClickStop()
	{
		if (BarcodeScanner == null) return;

		//BarcodeScanner.Destroy();
		//BarcodeScanner = null;
		Image.enabled = false;
		// Stop Scanning
		BarcodeScanner.Stop();
		BarcodeScanner.Camera.Stop();
	}

	/// <summary>
	/// This coroutine is used because of a bug with unity (http://forum.unity3d.com/threads/closing-scene-with-active-webcamtexture-crashes-on-android-solved.363566/)
	/// Trying to stop the camera in OnDestroy provoke random crash on Android
	/// </summary>
	/// <param name="callback"></param>
	/// <returns></returns>
	public IEnumerator StopCamera(Action callback)
	{
		// Stop Scanning
		Image = null;
		BarcodeScanner.Destroy();
		BarcodeScanner = null;

		// Wait a bit
		yield return new WaitForSeconds(0.1f);

		callback.Invoke();
	}

	#endregion
}
