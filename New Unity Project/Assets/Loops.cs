using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour 
{   
	void Start () 
	{
		string[] strings = new string[3];

		strings[0] = "Strike one!";
		strings[1] = "Strike two!";
		strings[2] = "Strike three! You're OUT!";

		foreach(string item in strings)
		{
			print (item);
		}
	}
}