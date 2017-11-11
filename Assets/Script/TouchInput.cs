using UnityEngine;

/// <summary>
/// ぷにコンクラス
/// ホールド座標から現在座標への向きを取得する
/// </summary>
public class TouchInput : SingletonMonoBehaviour<TouchInput>
{
	private Vector2 _axis = new Vector2();

	/// <summary>
	/// １フレーム前に入力されたタッチ座標
	/// </summary>
	private Vector2 _holdPosition = new Vector2();


	private void LateUpdate()
	{
		if (Input.GetMouseButtonDown(0))
		{
			// マウス座標の取得
			_holdPosition = Input.mousePosition;
			
		}
		if(Input.GetMouseButton(0))
		{
			Vector2 currentPosition = Input.mousePosition;
			// 差分を求める
			Vector2 diff = currentPosition - _holdPosition;
			// 正規化
			_axis = new Vector2(diff.x / (Mathf.Abs(diff.x) + Mathf.Abs(diff.y)), diff.y / (Mathf.Abs(diff.x) + Mathf.Abs(diff.y)));
		}
		if(Input.GetMouseButtonUp(0))
		{
			// 初期化
			_axis = new Vector2();
		}
	}

	public static Vector2 GetAxis()
	{
		return Instance._axis;
	}
}
