using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilStainManager : MonoBehaviour {

	public static OilStainManager instance;


	//================================================================= variables ===================================================================================
	public Sprite oilMask;//to be used to determine the general radius of the area of the oil
	public float oilMaskRadius;
	public float oilStainMaxRadius;

	public List<GameObject> oilStains;//will hold all oil stains
	public Dictionary<string, Vector3> oilStainsPositions;//will map all oil stains positions along with names so we can keep track







	//================================================================= Stain management methods ========================================================================
	public void StainChangedPosition(GameObject stainGO)
	{
		if (oilStainsPositions.ContainsKey (stainGO.name))
		{
			oilStainsPositions [stainGO.name] = stainGO.transform.position;
		}
		else
			oilStainsPositions.Add (stainGO.name, stainGO.transform.position);
		//either way, after that's done, update position vectors of the shader
		UpdateShaderStainPositions();
			

	}

	public void NewStainCreated(GameObject newStain)
	{
		oilStains.Add (newStain);
		oilStainsPositions.Add (newStain.name, newStain.transform.position);
		UpdateAllShaderValues ();
	}

	public void StainGotDestroyed(GameObject DestroyedStain)
	{
		oilStains.Remove(DestroyedStain);
		oilStainsPositions.Remove(DestroyedStain.name);
		UpdateAllShaderValues ();
	}



	public Vector4[] getAllOilPositions ()
	{
		Vector4[] oilPositionsVector = new Vector4[oilStains.Count]; //creates a vector3 array (needs to be array because it has to be sent to shader)
		int i = 0;//to help us iterate
		foreach (KeyValuePair<string, Vector3> oilStain in oilStainsPositions)
		{
			oilPositionsVector [i] = oilStain.Value;//get the value on that position, send it to Vector3 array(no need to worry that much about order now)
			i++;
		}

		return oilPositionsVector;
	}



	//============================================================= shader management methods ============================================================================

	/// <summary>
	/// Updates all shader values.
	/// </summary>
	public void UpdateAllShaderValues()
	{
		//runs every time a change is made( stain is created/destroyed/changed)
		Shader.SetGlobalFloat ("oilStainMinimumRadius", oilMaskRadius);
		Shader.SetGlobalFloat ("oilStainMaximumRadius", oilStainMaxRadius);
		Shader.SetGlobalInt("numberOfOilStains", oilStains.Count);
		UpdateShaderStainPositions ();
	}

	/// <summary>
	/// Updates the shader's stain positions. Called mainly when a stain moves.
	/// </summary>
	public void UpdateShaderStainPositions()
	{
		Vector4[] tmp = getAllOilPositions ();
		Shader.SetGlobalVectorArray ("oilCenterPositions", tmp);

	}


	// Use this for initialization
	void Start () {

		//singleton
		if (instance == null)
			instance = this;
		else
			Destroy (this.gameObject);

		//this will hold all oil stains in existance(TODO: this is the setting up, need to adapt this to be changed at runtime)
		oilStains = new List<GameObject> ();
		oilStains.AddRange(GameObject.FindGameObjectsWithTag ("Mancha"));

		//will hold a dictionary with names and positions, to be easier to change the recorded position of a stain at runtime
		oilStainsPositions = new Dictionary<string, Vector3>();
		for (int i = 0; i < oilStains.Count; i++)
		{
			oilStainsPositions.Add (oilStains [i].name, oilStains [i].transform.position); 
		}

		//calculates info to send to shaders
		oilMaskRadius = 3.4f; //minimum radius of stain, i.e., where the stain will always be black.
		oilStainMaxRadius = oilMaskRadius+1.8f;

		//sends info to shaders

		Shader.SetGlobalFloat ("oilStainMinimumRadius", oilMaskRadius);
		Shader.SetGlobalFloat ("oilStainMaximumRadius", oilStainMaxRadius);
		Shader.SetGlobalInt("numberOfOilStains", oilStains.Count);
		Vector4[] tmp = getAllOilPositions ();
		Shader.SetGlobalVectorArray ("oilCenterPositions", tmp);//TODO: this needs to be resent every time a stain is created/destroyed/moved


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
