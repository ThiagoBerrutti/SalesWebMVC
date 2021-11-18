using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;
using SalesWebMVC.Services.Exceptions;

namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly SalesWebMVCContext _context;

        public SellerService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(seller => seller.Department).FirstOrDefault(s => s.Id == id);
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.Include(c=> c.Department).ToList();
        }

        public void Remove(int id)
        {
            Seller seller = FindById(id);
            if (seller != null)
            {
                _context.Seller.Remove(seller);
                _context.SaveChanges();
            }
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public void Update(Seller seller)
        {
            if (!_context.Seller.Any(s => s.Id == seller.Id))
            {
                throw new NotFoundException("Seller with this Id not found");
            }

            try
            {
                _context.Update(seller);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message, e);
            }
        }
    }
}
