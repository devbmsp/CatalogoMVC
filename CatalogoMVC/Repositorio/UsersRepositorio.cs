﻿using CatalogoMVC.Data;
using CatalogoMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogoMVC.Repositorio
{
    public class UsersRepositorio : Interface
    {
        private readonly BancoContext _bancoContext;
        public UsersRepositorio(BancoContext bancoContext) 
        {
            _bancoContext = bancoContext;
        }
        public HomeModel Adicionar(HomeModel user)
        {
            _bancoContext.Users.Add(user);
            _bancoContext.SaveChanges();
            return user;
        }

        public HomeModel Atualizar(HomeModel user)
        {
            HomeModel userBD = ListarPorId(user.Id);

            if (userBD == null) throw new System.Exception("Houve um erro na atualização do contato!");

            userBD.Name = user.Name;
            userBD.Email = user.Email;
            userBD.Gender = user.Gender;
            userBD.Username = user.Username;
            userBD.Zip = user.Zip;
            userBD.Password = user.Password;

            _bancoContext.Users.Update(userBD);
            _bancoContext.SaveChanges();

            return userBD;

        }

        public bool Deletar(int Id)
        {
            HomeModel userDB = ListarPorId(Id);
            if (userDB == null) throw new System.Exception("Error !");
            _bancoContext.Users.Remove(userDB);
            _bancoContext.SaveChanges();
            return true;

        }

       

        public HomeModel ListarPorId(int Id)
        {
            return _bancoContext.Users.FirstOrDefault(x => x.Id == Id);
        }


    }
}
