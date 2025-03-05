using AutoMapper;
using Ecom.Core.Interfaces;
using Ecom.Core.Services;
using Ecom.Infrastructure.Data;
using Ecom.Infrastructure.Repositories.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    private readonly IImageManagementService _imageManagementService;

    public ICategoryRepositry CategoryRepositry { get; }

    public IPhotoRepositry PhotoRepositry { get; }

    public IProductRepositry ProductRepositry { get; }

    public UnitOfWork(AppDbContext context, IMapper mapper, IImageManagementService imageManagementService)
    {
        _context = context;
        _mapper = mapper;
        _imageManagementService = imageManagementService;
        CategoryRepositry = new CategoryRepositry(_context);
        PhotoRepositry = new PhotoRepositry(_context);
        ProductRepositry = new ProductRepositry(_context, _mapper, _imageManagementService);
    }
}
