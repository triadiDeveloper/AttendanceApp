using Attendance.Domain.BaseEntities;
using Microsoft.AspNetCore.Mvc;

namespace Attendance.API.Helper
{
    public static class ResponseHelper
    {
        public static ResponseModel Success(string? message = null)
        {
            return new ResponseModel
            {
                Code = "0000",
                Name = "Success",
                Message = message ?? ResponseCodes.Dict["0000"]
            };
        }

        public static ResponseModel Error(string code)
        {
            return new ResponseModel
            {
                Code = code,
                Name = ResponseCodes.Dict.ContainsKey(code) ? ResponseCodes.Dict[code] : "Unknown",
                Message = ResponseCodes.Dict.ContainsKey(code) ? ResponseCodes.Dict[code] : "Terjadi kesalahan"
            };
        }

        public static ResponseModel Custom(string code, string message)
        {
            return new ResponseModel
            {
                Code = code,
                Name = ResponseCodes.Dict.ContainsKey(code) ? ResponseCodes.Dict[code] : "Custom",
                Message = message
            };
        }

        public static IActionResult SuccessResponse<T>(T data, string? message = null)
        {
            return new JsonResult(new
            {
                Data = data,
                Status = Success(message)
            })
            {
                StatusCode = 200
            };
        }

        public static IActionResult CreatedResponse<T>(T data, string? message = null)
        {
            return new JsonResult(new
            {
                Data = data,
                Status = Success(message ?? "Data berhasil dibuat")
            })
            {
                StatusCode = 201
            };
        }

        public static IActionResult NotFoundResponse(string? message = null)
        {
            return new JsonResult(new
            {
                Status = Custom("404", message ?? "Data tidak ditemukan")
            })
            {
                StatusCode = 404
            };
        }

        public static IActionResult BadRequestResponse(string? code = "400", string? message = null)
        {
            return new JsonResult(new
            {
                Status = Custom(code!, message ?? "Permintaan tidak valid")
            })
            {
                StatusCode = 400
            };
        }

        public static object UnauthorizedObject(string? code = "U001", string? message = null)
        {
            return new
            {
                Status = Custom(code!, message ?? "Token tidak valid atau belum login")
            };
        }


        public static IActionResult ForbiddenResponse(string? code = "U003", string? message = null)
        {
            return new JsonResult(new
            {
                Status = Custom(code!, message ?? "Akses ditolak")
            })
            {
                StatusCode = 403
            };
        }
    }
}