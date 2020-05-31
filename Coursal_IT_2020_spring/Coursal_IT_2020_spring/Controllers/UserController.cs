using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Coursal_IT_2020_spring.Models;
using Coursal_IT_2020_spring.Services.Interfaces;
using Coursal_IT_2020_spring.ViewModels;

namespace Coursal_IT_2020_spring.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public UserController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        /// <summary>
        /// Получить информацию по аккаунтам
        /// </summary>
        /// <param name="пользователи">пользователи</param>
        /// <returns>Ответ сервера.</returns>
        [HttpGet]
        [Route("GetAccounts")]
        [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAccounts()
        {
            try
            {
                var accounts= await _accountService.GetAccounts();
                return Ok(accounts);
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        /// <summary>
        /// Добавить новый блог и пользователя
        /// </summary>
        /// <param name="пользователь">пользователь</param>
        /// <returns>Ответ сервера.</returns>
        [HttpPost]
        [Route("CreateAccount")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateAccount([FromBody] UserViewModel user)
        {
            try
            {
                await _accountService.CreateAccount(user.ToUserObject());
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        /// <summary>
        /// Удалить аккаунт
        /// </summary>
        /// <returns>Ответ сервера.</returns>
        [HttpPost]
        [Route("DeleteAccount/{authorNickname?}/{password?}")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(string nickname, string password)
        {
            try
            {
                await _accountService.DeleteAccount(nickname, password);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        /// <summary>
        /// Обновить аккаунт
        /// </summary>
        /// <returns>Ответ сервера.</returns>
        [HttpPost]
        [Route("UpdateAccount")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update([FromBody] UserViewModel user)
        {
            try
            {
                await _accountService.Update(user.ToUserObject());
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
    }
}
