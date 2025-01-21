using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Domain.Entities;

public record ProductEntity(int Id, string Description, decimal Price);