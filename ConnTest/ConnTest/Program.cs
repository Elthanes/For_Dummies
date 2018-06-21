using System;
using System.Net.Http;
namespace ConnTest
{
    class Program
    {
        static void Main(string[] args)
        {

            using (HttpClient client = new HttpClient())
            {

                String url = "https://7ss3rsj2og.execute-api.eu-central-1.amazonaws.com/Eh/TokenDecode";
                String token = "eyJraWQiOiJwUFY4M1I2cUNpb2JRdzIza1RwQ21yeHJ5eTQwQzlZS2JtY0p1TmVob05jPSIsImFsZyI6IlJTMjU2In0.eyJzdWIiOiJiNDQwYWIxNy03MjE2LTQ0N2MtYTFmMC1hNzNlNzExMTUyZGIiLCJhdWQiOiI0azdtYnYyaWwyb2tkOGp0bWU2M3Q0M2FhNiIsImVtYWlsX3ZlcmlmaWVkIjp0cnVlLCJldmVudF9pZCI6ImRmNmRjMmQ1LTc0NzgtMTFlOC04YzVjLWFmMWQ5NTQyM2UxOSIsInRva2VuX3VzZSI6ImlkIiwiYXV0aF90aW1lIjoxNTI5NDkyMzEyLCJpc3MiOiJodHRwczpcL1wvY29nbml0by1pZHAuZXUtY2VudHJhbC0xLmFtYXpvbmF3cy5jb21cL2V1LWNlbnRyYWwtMV9zd3hlUVFCWloiLCJwaG9uZV9udW1iZXJfdmVyaWZpZWQiOmZhbHNlLCJjb2duaXRvOnVzZXJuYW1lIjoiYWJjZCIsImV4cCI6MTUyOTQ5NTkxMiwiaWF0IjoxNTI5NDkyMzEyLCJlbWFpbCI6ImMubS5iZW5kZXJAZ214LmRlIn0.Vu727n0hGnNpnHs4GTT_8i6-_MZJmA265GC4kikRKn8uiHmUfdLAxqWTB1dJy9xqDEzWJfSAvkGDNecr2F1anDKerWdMnIW_fgLG2D-8gLWHV3pBIR-Xa1ov-cwdqCZ94E9c3z-gZfAbJ2hBMtVHaB3-LAX0ttFH95SOHKKHrc6jbFsrVd6CFS_55EIOyzl-Wavc0geiN9Av-6F8qTnUUtqDhoEc74MgPF7jKAa8uQso0zXJKhDCxcHOmXCo1d36aMfDP8KF-8R5iYHEvLuoHm7CNO0e9MhEeChy2KcoycRCmb07R8tu7f1BC27rD8s1XlbdYw8je760lNcfVDMW3Q";
                String outa = "";
                var content = new StringContent(token, System.Text.Encoding.UTF8, "text/plain");
                using(var response = client.PostAsync(url, content).Result){
                    outa = response.Content.ReadAsStringAsync().Result;
                }
                Console.WriteLine(outa);
                Console.ReadLine();
            }
        }

    }

}
