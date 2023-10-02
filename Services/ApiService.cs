using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class MockApiService
{
    private Dictionary<string, UserInfo> _userInfos;

    public MockApiService()
    {
        // Inicializar o dicion�rio com tokens e informa��es associadas
        _userInfos = new Dictionary<string, UserInfo>
        {
            { "token1", new UserInfo { Name = "User 1", Email = "user1@example.com" } },
            { "token2", new UserInfo { Name = "User 2", Email = "user2@example.com" } }
        };
    }

    public Task<bool> LoginAsync(string loginToken)
    {
        bool isValid = _userInfos.ContainsKey(loginToken);
        return Task.FromResult(isValid);
    }

    public UserInfo GetUserInfo(string loginToken)
    {
        if (_userInfos.TryGetValue(loginToken, out var userInfo))
        {
            return userInfo;
        }
        throw new Exception("Token inv�lido ou usu�rio n�o autenticado.");
    }

}
public class UserInfo
{
    public string Name { get; set; }
    public string Email { get; set; }
}