using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
                             //.Include(pa => pa.ParkingAreaType) 
                             .ToListAsync();
    }

    
    public async Task<ParkingAreas> GetParkingAreaByIdAsync(int id)
    {
        return await _context.ParkingAreas
         .FirstOrDefaultAsync(pa => pa.Id == id);

    }

    public async Task<ParkingAreas> CreateParkingAreaAsync(ParkingAreas parkingArea)
    {
        _context.ParkingAreas.Add(parkingArea);
        await _context.SaveChangesAsync();
        return parkingArea;
    }

    public async Task<IEnumerable<ParkingAreaTypes>> GetAllParkingAreaTypesAsync()
    {
        return await _context.ParkingAreaTypes
                             //.Include(pa => pa.ParkingAreaType) 
                             .ToListAsync();
    }

    public async  Task<IEnumerable<ParkingPermits>> GetAllParkingPermitsAsync()
    {
        return await _context.ParkingPermits
                             .Include(pp => pp.ParkingArea) 
                             .ToListAsync();
    }



    // public async Task<ParkingAreas> UpdateParkingAreaAsync(ParkingAreas parkingArea)
    // {
    //     _context.ParkingAreas.Update(parkingArea);
    //     await _context.SaveChangesAsync();
    //     return parkingArea;
    // }

    // public async Task<bool> DeleteParkingAreaAsync(ParkingAreas parkingArea)
    // {
    //     _context.ParkingAreas.Remove(parkingArea);
    //     var result = await _context.SaveChangesAsync();
    //     return result > 0; 
    // }

    public async Task<ParkingAreaTypes> CreateParkingAreaTypeAsync(ParkingAreaTypes parkingAreaType)
    {

        _context.ParkingAreaTypes.Add(parkingAreaType);
        await _context.SaveChangesAsync();
        return parkingAreaType; 
    }

    public async Task<ParkingPermits>CreateParkingPermitAsync(ParkingPermits parkingPermit)
    {
         _context.ParkingPermits.Add(parkingPermit);
        await _context.SaveChangesAsync();

         var newParkingPermit = await _context.ParkingPermits
        .Include(p => p.ParkingArea) 
        .FirstOrDefaultAsync(p => p.Id == parkingPermit.Id);

        return newParkingPermit;
    }

    public async Task<ParkingAreas> UpdateParkingAreaAsync(ParkingAreas parkingArea, int id)
    {
        var existingParkingArea = await _context.ParkingAreas.FirstOrDefaultAsync(pa => pa.Id == id);

        existingParkingArea.ParkingAreaTypeID = parkingArea.ParkingAreaTypeID;
        existingParkingArea.ParkingAreaName = parkingArea.ParkingAreaName;
        existingParkingArea.Latitude = parkingArea.Latitude;
        existingParkingArea.Longitude = parkingArea.Longitude;
        existingParkingArea.Inactive = parkingArea.Inactive;

        await _context.SaveChangesAsync();
        return existingParkingArea; 
    }

    public async Task<ParkingAreaTypes> UpdateParkingAreaTypeAsync(ParkingAreaTypes parkingAreaType, int id)
    {
        var existingParkingAreaType = await _context.ParkingAreaTypes.FirstOrDefaultAsync(pat => pat.Id == id);


        existingParkingAreaType.ParkingAreaTypeDescription = parkingAreaType.ParkingAreaTypeDescription;
        existingParkingAreaType.Inactive = parkingAreaType.Inactive;

        await _context.SaveChangesAsync();
        return existingParkingAreaType; 
    }
    public async Task<ParkingPermits> UpdateParkingPermitAsync(ParkingPermits parkingPermit, int id)
    {
        var existingParkingPermit = await _context.ParkingPermits
                                        .Include(pp=>pp.ParkingArea)
                                        .FirstOrDefaultAsync(pp => pp.Id ==id);

        existingParkingPermit.ParkingAreaID = parkingPermit.ParkingAreaID;
        existingParkingPermit.EffectiveDate = parkingPermit.EffectiveDate;
        existingParkingPermit.ExpirationDate = parkingPermit.ExpirationDate;
        existingParkingPermit.LicensePlate = parkingPermit.LicensePlate;
        existingParkingPermit.Inactive = parkingPermit.Inactive;

        await _context.SaveChangesAsync();
        return existingParkingPermit; 

    }

    public async Task<bool> DeleteParkingPermitAsync(int id)
    {
        var parkingPermitDelete = await _context.ParkingPermits
                                            .FirstOrDefaultAsync(pat => pat.Id == id);

        _context.ParkingPermits.Remove(parkingPermitDelete);

        await _context.SaveChangesAsync();

        return true;

    }
    public async Task<bool> DeleteParkingAreaAsync(int id)
    {
        var parkingAreaDelete = await _context.ParkingAreas
                                            .FirstOrDefaultAsync(pat => pat.Id == id);

        _context.ParkingAreas.Remove(parkingAreaDelete);

        await _context.SaveChangesAsync();

        return true;
    }
    public async Task<bool> DeleteParkingAreaTypeAsync(int id)
    {
        var parkingAreaTypeDelete = await _context.ParkingAreaTypes
                                            .FirstOrDefaultAsync(pat => pat.Id == id);

        _context.ParkingAreaTypes.Remove(parkingAreaTypeDelete);

        await _context.SaveChangesAsync();

        return true;
    }


}
