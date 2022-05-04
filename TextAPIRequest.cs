using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net.Http;
using System.Net.Http.Headers;

// // Trying to import a json deserializer
// using Newtonsoft.Json;

public class TextScript : MonoBehaviour
{
    // // Text text;
    // int i;

    private const string url = "https://fake-clases-api-m3g35jkzdq-uc.a.run.app/aulas";
    private string urlParameters = "";

    // Start is called before the first frame update
    void Start()
    {
        // i = 0;
        // // text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(url);

        client.DefaultRequestHeaders.Accept.Add(
          new MediaTypeWithQualityHeaderValue("application/json")
        );

        HttpResponseMessage response = client.GetAsync(urlParameters).Result;

        if (response.IsSuccessStatusCode)
        {
            var raw_json = response.Content.ReadAsStringAsync().Result;

            Debug.Log(raw_json);

            // // Trying to deserialize json string
            // JsonConvert.DeserializeObject<RecipeList>(raw_json);
        }
        else
        {
            // // Some error
            // Debug.Log(response.StatusCode, response.ReasonPhrase);
        }


        // // text.text = "i = " + i;
        // Debug.Log("i = " + i);
        // i += 1;
    }
}
