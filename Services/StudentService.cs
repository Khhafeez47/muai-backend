using Abp.Web.Mvc.Alerts;
using DevOpsApp.Interfaces;
using DevOpsApp.Models;
using Newtonsoft.Json;
using System.Text;

namespace DevOpsApp.Services
{
    public class StudentService : IStudentService
    {
        string baseUrl = "https://localhost:44339";
        public async Task<bool> PostStudentRecord(Student student)
        {
			try
			{
                using (var client = new HttpClient())
                {
                    var url = $"{baseUrl}/api/Student";

                    var serializeContent = JsonConvert.SerializeObject(student);

                    var apiResponse = await client.PostAsync(url, new StringContent(serializeContent, Encoding.UTF8, "application/json"));

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        return true;
                    }
                    else
                        return false;
                }
			}
			catch (Exception)
			{
                return false;
			}
        }
    }
}
