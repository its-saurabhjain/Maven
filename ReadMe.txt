cd to the directory where we have docker-compose.dcproj
docker-compose up

//note that while invoking a web api we do not use http://localhost:5000
rather it is replaced by the name of the project birthdefectregistry in our case. 

System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
var result = client.GetAsync("http://birthdefectregistry/api/Birthdefect").Result;
string text = result.Content.ReadAsStringAsync().Result;

