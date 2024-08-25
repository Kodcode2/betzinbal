﻿using Microsoft.EntityFrameworkCore;
using MosadRest.Models;

namespace MosadRest.Services
{
    public interface IMissionService
    {
        public Task<List<MissionModel>?> GetOffersByAgentIdAsync(int id);
        public Task ConfromandEditMussunsForAgentAsinc(AgentModel agent);
        public Task ChkAndCreateMissinsForAgentAsync(AgentModel agent);
        public Task<List<MissionModel>?> GetOffersByTargetIdAsync(int id);
        public Task ConfromandEditMussunsForTargetAsinc(TargetModel target);
        public Task ChkAndCreateMissinsForTargetAsync(TargetModel target);
        public Task<MissionModel> GetMissionByIdAsync(int id);
        public Task<List<MissionModel?>> GetAllMisionsasync();
        public Task UpdteMission();
        public Task AssimntMission(int id);




        //public Task<List<MissionModel>?> GetAllMissionsAsync();
        //public Task<bool> LokforNewMissionsForAgentAsync(AgentModel agent);
        //public Task<bool> AssignedMiisionAsync(MissionModel mission);

    }
}
