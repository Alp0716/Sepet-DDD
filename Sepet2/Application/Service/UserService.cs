using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using Domain.Interfaces;
using Application.AutoMapper;
using Domain.Command;
using Domain.Validation;
using FluentValidation.Results;
using Application.ServiceAuth;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace Application.Service
{
    public class UserService : BaseService, IUserService<User>
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository userRepository;
        
        public UserService(IMediator mediator, IMapper mapper, IUnitOfWork unitOfWork, IUserRepository _userRepository)
        {
            _mediator = mediator;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            userRepository = _userRepository;
        }
        public Task<IEnumerable<User>> GetAll()
        {
            var user = new User();
            var result = _mapper.Map<CreateUserCommand>(user).ToString();
            var item = userRepository.GetAll();
            return item;
        }
        public Task UserAdd(User user)
        {
            var result = _mapper.Map<CreateUserCommand>(user);
            return Task.FromResult(true);
        }
        public Task<int> UserDelete(int id)
        {
            var result = _mediator.Send(new DeleteUserCommand() { UserId = id });     
            return Task.FromResult(result.Id);
            
        }
        public Task<int> UserUpdate(User entity)
        {
            var user1 = new User();
            user1.UserId = entity.UserId;
            user1.UserName = entity.UserName;
            user1.LastName = entity.LastName;
            user1.Password = entity.Password;
            var result = _mapper.Map<UpdateUserCommand>(user1);
            var item = _mediator.Send(result);
            return Task.FromResult(item.Result);
        }
    }
}
