using System;
using System.IO;
using System.Reflection;
using BepInEx;
using SophisticatedCube.AssetBundles;
using UnityEngine;
using UnityEngine.Animations.Rigging;

namespace SophisticatedCube
{
    [BepInPlugin("com.ngbatz.gorillatag.sophisticatedcube", "SophisticatedCube", "2.0.0")]
	public class Plugin : BaseUnityPlugin
	{
		public static Plugin instance;
        //public static AssetBundle bundle;
        public static GameObject assetBundleParent;

        Material material = new Material(Shader.Find("Universal Render Pipeline/Lit"));
        /*public static string assetBundleName = "grabbbbb";
        public static string parentName = "BundleParent (put objects in here DONT MOVE)";*/

        public void Start()
		{
			instance = this;
			/*bundle = LoadAssetBundle("SophisticatedCube.AssetBundles." + assetBundleName);
            assetBundleParent = Instantiate(bundle.LoadAsset<GameObject>(parentName));*/
            assetBundleParent = GameObject.CreatePrimitive(PrimitiveType.Cube);
            assetBundleParent.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            material.color = Color.green;
            assetBundleParent.GetComponent<Renderer>().material = material;
            assetBundleParent.GetComponent<BoxCollider>().enabled = false;
            assetBundleParent.transform.position = new Vector3(-67.2225f, 11.57f, -82.611f);
            assetBundleParent.AddComponent<HoldableEngine>();
        }

        /*public AssetBundle LoadAssetBundle(string path)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path);
            AssetBundle bundle = AssetBundle.LoadFromStream(stream);
            stream.Close();
            return bundle;
        }*/
    }
}