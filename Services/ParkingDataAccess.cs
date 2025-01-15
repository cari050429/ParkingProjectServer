using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParkingProjectServer.Data;

public class ParkingDataAccess : IParkingDataAccess
{
    private readonly ParkingDbContext _context;

    public ParkingDataAccess(ParkingDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ParkingAreas>> GetAllParkingAreasAsync()
    {
        return await _context.ParkingAreas
                             .Include(pa => pa.ParkingAreaType) 
                             .ToListAsync();
    }

    public async Task<ParkingAreas> CreateParkingAreaAsync(ParkingAreas parkingArea)
    {
        _context.ParkingAreas.Add(parkingArea);
        await _context.SaveChangesAsync();
        return parkingArea;
    }

    public async Task<ParkingAreas> UpdateParkingAreaAsync(ParkingAreas parkingArea)
    {
        _context.ParkingAreas.Update(parkingArea);
        await _context.SaveChangesAsync();
        return parkingArea;
    }

    public async Task<bool> DeleteParkingAreaAsync(ParkingAreas parkingArea)
    {
        _context.ParkingAreas.Remove(parkingArea);
        var result = await _context.SaveChangesAsync();
        return result > 0; 
    }

    public async Task<ParkingAreaTypes> CreateParkingAreaTypeAsync(ParkingAreaTypes parkingAreaType)
    {
        _context.ParkingAreaTypes.Add(parkingAreaType);
        await _context.SaveChangesAsync();
        return parkingAreaType; // change this to return the new parking area type that was just made 
    }

}
