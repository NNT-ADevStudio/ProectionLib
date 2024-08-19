using ProectionLib.Models;
using ProectionLib.Models.HelperModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;

namespace ProectionLib.Controllers
{
    public class TestingController : MainController
    {
        public TestingController(Auth auth) : base(auth) { }

        public override string ControllerUrl => "testing";

        public async Task<ListModel<Testing>> GetTestingList(int complite = 1, int page = 1)
        {
            try
            {
                using (var client = Auth.GenerateHttpClient())
                {
                    var response = await client.GetAsync($"{ControllerUrl}/list?page={page}&complete={complite}");
                    response.EnsureSuccessStatusCode();

                    ListModel<Testing> testings = new ListModel<Testing>();

                    var json = await response.Content.ReadAsStringAsync();

                    testings.TotalItems = Convert.ToInt32(response.Headers.GetValues("x-pagination-total-count").FirstOrDefault());
                    testings.TotalPages = Convert.ToInt32(response.Headers.GetValues("x-pagination-page-count").FirstOrDefault());
                    testings.Count = Convert.ToInt32(response.Headers.GetValues("x-pagination-per-page").FirstOrDefault());
                    testings.Page = Convert.ToInt32(response.Headers.GetValues("x-pagination-current-page").FirstOrDefault());

                    testings.Items = JsonSerializer.Deserialize<IEnumerable<Testing>>(json);

                    return testings;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Report> GetTestingReport(string id)
        {
            try
            {
                using (var client = Auth.GenerateHttpClient())
                {
                    var response = await client.GetAsync($"{ControllerUrl}/report?id={id}");
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<Report>(json);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<byte[]> GetResultFile(int id)
        {
            try
            {
                using (var httpClient = Auth.HttpClient)
                {
                    byte[] fileBytes = await httpClient.GetByteArrayAsync($"{ControllerUrl}/result?id={id}");
                    return fileBytes;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<DonwloadFile> GetResultFileWithName(string id)
        {
            try
            {
                DonwloadFile donwloadFile = new DonwloadFile();
                using (var httpClient = Auth.GenerateHttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync($"{ControllerUrl}/result?id={id}");

                    if (response.IsSuccessStatusCode)
                    {
                        donwloadFile.FileBytes = await response.Content.ReadAsByteArrayAsync();

                        if (response.Content.Headers.ContentDisposition != null)
                            donwloadFile.FileName = response.Content.Headers.ContentDisposition.FileName;
                        donwloadFile.FileNameStar = response.Content.Headers.ContentDisposition.FileNameStar;
                    }
                }

                return donwloadFile;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
