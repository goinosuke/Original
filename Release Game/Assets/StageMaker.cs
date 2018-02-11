using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StageMaker : MonoBehaviour {

	int currentIndex;

	int StageSize = 100;  //ステージの長さ
	public Transform character;
	public GameObject[] stageTips; //生成するStageの配列数
	public int startTipIndex;
	public int preInstantiate;
	public List<GameObject> generatedStageList = new List<GameObject>();

	// Use this for initialization
	void Start ()
	{
		currentIndex = startTipIndex - 1;
		MakingStage (preInstantiate);
	}

	// Update is called once per frame
	void Update () {
		int charaPositionIndex = (int)(character.position.z / StageSize);

		if (charaPositionIndex + preInstantiate > currentIndex) 
		{
			MakingStage(charaPositionIndex + preInstantiate);
		}
	}
	void MakingStage(int toTipIndex) // ステージをインデックス指定分まで生成し管理します
	{
		if (toTipIndex <= currentIndex) return;
		//指定分のステージを配置します。
		for (int i = currentIndex + 1; i <= toTipIndex; i++) 
		{
			GameObject stageObject = GenerateStage(i);
			generatedStageList.Add(stageObject);
		}
		while (generatedStageList.Count > preInstantiate +2)
			DestroyStage ();
		currentIndex = toTipIndex;
	}

	GameObject GenerateStage(int tipIndex) // 実際に生成します
	{
		int nextStageTip = Random.Range (0, stageTips.Length);

        GameObject stageObject = (GameObject)Instantiate (stageTips [nextStageTip], new Vector3 (0, 0, tipIndex * StageSize), Quaternion.identity);
		return stageObject;
	}

	void DestroyStage()
	{
		GameObject oldStage = generatedStageList [0];
		generatedStageList.RemoveAt (0);
		Destroy (oldStage);
	}
}
