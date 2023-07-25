    public async Task PatchAsync<T>(string auth, string path, T view)
    {
        _client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(auth);

        var json = JsonSerializer.Serialize(view, JsonSerialisationOptions.DefaultOptions);

        var response = await _client.PatchAsync(BuildUri(path), new StringContent(json, Encoding.UTF8, "application/json"));

        respone.EnsureSuccessStatusCode()
    }
