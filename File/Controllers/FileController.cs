using Amazon.S3;
using Amazon.S3.Model;
using File.Application.Commands;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace File.Controllers
{
    [Route("api/v1/files")]
    public class FileController : ControllerBase
    {
        private IAmazonS3 _s3;

        public FileController(IAmazonS3 s3)
        {
            _s3 = s3;
        }

        [Route("createFile")]
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateFileAsync([FromBody] CreateFileCommand command, [FromHeader(Name = "x-requestid")] string requestId)
        {
            bool isFileCreated = false;

            if(Guid.TryParse(requestId, out Guid result))
            {
                try
                {
                    var putRequest1 = new PutObjectRequest
                    {
                        BucketName = command.BucketName,
                        Key = command.FileName,
                        ContentBody = command.Body
                    };

                    PutObjectResponse response1 = await _s3.PutObjectAsync(putRequest1);

                    Console.WriteLine($"Status code: {response1.HttpStatusCode}");
                }
                catch(Exception ex)
                {

                }
            }

            return Ok();
        }
    }
}
