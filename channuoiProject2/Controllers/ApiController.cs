using channuoiProject2.ApiModels;
using Microsoft.AspNetCore.Mvc;

namespace channuoiProject2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<ApiController> _logger;
        private Worker worker { get; set; }
        public Database Database { get; set; }
        public ApiController(ILogger<ApiController> logger, Database database)
        {
            _logger = logger;
            Database = database;
            worker = new Worker(Database);
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpPost("AddVaccin")]
        public async Task<Result> AddVaccin([FromBody] AddVaccin vaccinModel)
        {
            try
            {
                bool res = await worker.FuncAddVaccin(vaccinModel);
                if (res)
                {
                    return new Result(200, "Done");
                }
                else
                {
                    return new Result(500, "Error Database");
                }
            }
            catch (Exception ex)
            {
                return new Result(204, ex.ToString());
            }
        }

        [HttpPost("AddOdich")]
        public async Task<Result> AddOdich([FromBody] AddODich vaccinModel)
        {
            try
            {
                bool res = await worker.FuncAddOdich(vaccinModel);
                if (res)
                {
                    return new Result(200, "Done");
                }
                else
                {
                    return new Result(500, "Error Database");
                }
            }
            catch (Exception ex)
            {
                return new Result(204, ex.ToString());
            }
        }
        [HttpPost("AddCoSo")]
        public async Task<Result> AddCoSo([FromBody] AddCoso vaccinModel)
        {
            try
            {
                bool res = await worker.FuncAddCoSo(vaccinModel);
                if (res)
                {
                    return new Result(200, "Done");
                }
                else
                {
                    return new Result(500, "Error Database");
                }
            }
            catch (Exception ex)
            {
                return new Result(204, ex.ToString());
            }
        }
        [HttpPost("AddDichBenh")]
        public async Task<Result> AddDichBenh([FromBody] AddDichBenh vaccinModel)
        {
            try
            {
                bool res = await worker.FuncAddDichBenh(vaccinModel);
                if (res)
                {
                    return new Result(200, "Done");
                }
                else
                {
                    return new Result(500, "Error Database");
                }
            }
            catch (Exception ex)
            {
                return new Result(204, ex.ToString());
            }
        }
        [HttpPost("AddLuatPhap")]
        public async Task<Result> AddLuatPhap([FromBody] AddLuatPhap vaccinModel)
        {
            try
            {
                bool res = await worker.FuncAddLuatPhap(vaccinModel);
                if (res)
                {
                    return new Result(200, "Done");
                }
                else
                {
                    return new Result(500, "Error Database");
                }
            }
            catch (Exception ex)
            {
                return new Result(204, ex.ToString());
            }
        }
        [HttpPost("AddTiemPhong")]
        public async Task<Result> AddTiemPhong([FromBody] AddTiemPhong vaccinModel)
        {
            try
            {
                bool res = await worker.FuncAddTiemPhong(vaccinModel);
                if (res)
                {
                    return new Result(200, "Done");
                }
                else
                {
                    return new Result(500, "Error Database");
                }
            }
            catch (Exception ex)
            {
                return new Result(204, ex.ToString());
            }
        }

        [HttpPost("GetCosoId")]
        public async Task<List<coso>> GetCoso([FromBody] GetCoso model)
        {
            try
            {
                var res = await worker.Getcoso(model);
                return res;
            }
            catch (Exception ex)
            {
                return new List<coso>();
            }
        }
        [HttpPost("GetLuatPhap")]
        public async Task<List<coso>> GetLuatPhap([FromBody] GetCoso model)
        {
            try
            {
                var res = await worker.Getcoso(model);
                return res;
            }
            catch (Exception ex)
            {
                return new List<coso>();
            }
        }
        [HttpPost("GetOdichId")]
        public async Task<List<odich>> GetOdichId([FromBody] GetCoso model)
        {
            try
            {
                var res = await worker.GetOdich(model);
                return res;
            }
            catch (Exception ex)
            {
                return new List<odich>();
            }
        }
        [HttpPost("GetDichBenh")]
        public async Task<List<dichbenh>> GetDichBenh([FromBody] GetCoso model)
        {
            try
            {
                var res = await worker.GetDichBenh(model);
                return res;
            }
            catch (Exception ex)
            {
                return new List<dichbenh>();
            }
        }
        [HttpPost("GetVaccin")]
        public async Task<List<vaccin>> GetVaccin([FromBody] GetCoso model)
        {
            try
            {
                var res = await worker.GetVaccin(model);
                return res;
            }
            catch (Exception ex)
            {
                return new List<vaccin>();
            }
        }
    }
}