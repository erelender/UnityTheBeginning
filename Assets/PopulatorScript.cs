using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulatorScript : MonoBehaviour {

	public GameObject cuber;
	public GameObject numberer;
	public Material blackMaterial;
	public Material whiteMaterial;

	public Material num0;
	public Material num1;
	public Material num2;
	public Material num3;
	public Material num4;
	public Material num5;
	public Material num6;
	public Material num7;
	public Material num8;
	public Material num9;
	public Material num10;

	int[,] layer = new int[10,10] {
		{1,1,0,0,0,0,0,0,0,1},
		{0,1,1,0,0,1,1,1,1,0},
		{0,0,1,1,0,0,0,1,0,1},
		{0,0,0,1,1,0,0,1,1,0},
		{0,0,0,0,1,1,0,1,0,1},
		{0,0,0,0,1,1,0,1,1,0},
		{0,0,0,1,1,1,1,1,0,1},
		{0,0,1,1,0,0,1,0,1,0},
		{0,1,1,0,1,1,1,1,0,1},
		{1,1,1,0,0,0,0,0,1,0}};

	// Use this for initialization
	void Start () {
		for (int row = 0; row < 10; ++row) {
			for (int col = 0; col < 10; ++col) {
				GameObject c = Instantiate (cuber);
				Vector3 pos = new Vector3 ( row , 0, col );
				c.transform.position = pos;

				Renderer r = c.GetComponent<Renderer> ();
				if (layer [row, col] == 1) {
					r.material = blackMaterial;
				} else {
					r.material = whiteMaterial;
				}
			}
		}

		List<int> nums = new List<int>();
		int current = 0;
		for (int row = 0; row < 10; ++row) {
			nums.Clear();
			current = 0;
			for (int col = 0; col < 10; ++col) {
				if (layer [row, col] == 1) {
					current++;
				} else {
					if(current > 0)
					{
						nums.Add(current);
						current = 0;
					}
				}
			}
			if (current > 0)
				nums.Add (current);
			print (nums.Count.ToString() + " blocks found for row " + row.ToString ());
			for (int index = 0; index < nums.Count; ++index) {
				print ("Number :" + nums [index].ToString ());
			}
			if (nums.Count > 0) {
				for(int index = 0; index < nums.Count; ++index)
				{
					GameObject c = Instantiate (numberer);
					Vector3 pos = new Vector3 ( row , 0, -(nums.Count - index) );
					Vector3 rot = new Vector3 ( 0 , 90, 0 );
					c.transform.position = pos;
					c.transform.Rotate (rot);

					Renderer r = c.GetComponent<Renderer> ();
					if (nums[index] == 1) {
						r.material = num1;
					} else if (nums[index] == 2) {
						r.material = num2;
					} else if (nums[index] == 3) {
						r.material = num3;
					} else if (nums[index] == 4) {
						r.material = num4;
					} else if (nums[index] == 5) {
						r.material = num5;
					} else if (nums[index] == 6) {
						r.material = num6;
					} else if (nums[index] == 7) {
						r.material = num7;
					} else if (nums[index] == 8) {
						r.material = num8;
					} else if (nums[index] == 9) {
						r.material = num9;
					} else if (nums[index] == 10) {
						r.material = num10;
					}
				}
			}
			else{
				GameObject c = Instantiate (numberer);
				Vector3 pos = new Vector3 ( row , 0, -1 );
				c.transform.position = pos;

				Renderer r = c.GetComponent<Renderer> ();
				r.material = num0;
			}
		}





		for (int col = 0; col < 10; ++col) {
			nums.Clear();
			current = 0;
			for (int row = 0; row < 10; ++row) {
				if (layer [row, col] == 1) {
					current++;
				} else {
					if(current > 0)
					{
						nums.Add(current);
						current = 0;
					}
				}
			}
			if (current > 0)
				nums.Add (current);
			if (nums.Count > 0) {
				for(int index = 0; index < nums.Count; ++index)
				{
					GameObject c = Instantiate (numberer);
					Vector3 pos = new Vector3 ( -(nums.Count - index) , 0, col );
					Vector3 rot = new Vector3 ( 0 , 90, 0 );
					c.transform.position = pos;
					c.transform.Rotate (rot);

					Renderer r = c.GetComponent<Renderer> ();
					if (nums[index] == 1) {
						r.material = num1;
					} else if (nums[index] == 2) {
						r.material = num2;
					} else if (nums[index] == 3) {
						r.material = num3;
					} else if (nums[index] == 4) {
						r.material = num4;
					} else if (nums[index] == 5) {
						r.material = num5;
					} else if (nums[index] == 6) {
						r.material = num6;
					} else if (nums[index] == 7) {
						r.material = num7;
					} else if (nums[index] == 8) {
						r.material = num8;
					} else if (nums[index] == 9) {
						r.material = num9;
					} else if (nums[index] == 10) {
						r.material = num10;
					}
				}
			}
			else{
				GameObject c = Instantiate (numberer);
				Vector3 pos = new Vector3 ( -1 , 0, col );
				c.transform.position = pos;

				Renderer r = c.GetComponent<Renderer> ();
				r.material = num0;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
