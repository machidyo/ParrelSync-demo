using UnityEngine;
using Cysharp.Threading.Tasks;
using Fusion;

public class PhotonManager : MonoBehaviour
{
    private NetworkRunner networkRunner;

    void Start()
    {
        networkRunner = gameObject.AddComponent<NetworkRunner>();
    }

    public async UniTask StartMultiPlay(INetworkRunnerCallbacks callbacks)
    {
        networkRunner.AddCallbacks(callbacks);
        var startGameArgs = new StartGameArgs
        {
            GameMode = GameMode.Shared,
        };
        await networkRunner.StartGame(startGameArgs);
    }
}