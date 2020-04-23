# Uni Remote Checker

Unity Remote 5 が接続されているかどうか確認するスクリプト  

## 使用例

```cs
using UniRemoteChecker;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Update()
    {
        if ( RemoteChecker.IsRemote )
        {
            Debug.Log( "Unity Remote 5 が接続されています" );
        }
    }
}
```
