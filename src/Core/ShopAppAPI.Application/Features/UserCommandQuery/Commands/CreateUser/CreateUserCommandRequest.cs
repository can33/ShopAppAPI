﻿using MediatR;

namespace ShopAppAPI.Application.Features.UserCommandQuery.Commands.CreateUser;
public class CreateUserCommandRequest : IRequest<BaseResponse<CreateUserCommandResponse>>
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string PasswordConfirm { get; set; }
}
