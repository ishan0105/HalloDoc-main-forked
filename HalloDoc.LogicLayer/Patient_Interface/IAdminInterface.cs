﻿using HalloDoc.DataLayer.Models;
using HalloDoc.DataLayer.ViewModels;
using HalloDocMvc.Entity.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloDoc.LogicLayer.Patient_Interface
{
    public interface IAdminInterface 
    {
        public AdminDashboardTableView ModelOfAdminDashboard(string? status);
        public Request ValidateRequest(int requestId);
        public RequestClient ValidateRequestClient(int requestClientId);
        public void EditViewCaseAction(ViewCaseModel userProfile, RequestClient userToUpdate);
        public RequestNote FetchRequestNote(int requestId);
        public RequestStatusLog FetchRequestStatusLogs(int requestId);
        public Physician FetchPhysician(int id);
        public void EditViewNotesAction(RequestNote rn, ViewNotes model);
        public CaseTag FetchCaseTag(int caseTagId);
        public void AddRequestStatusLogFromCancelCase(RequestStatusLog rs);
        public List<Physician> FetchPhysicianByRegion(int RegionId);
        public void AddBlockRequestData(BlockRequest br);
        public void UpdateRequest(Request r);
        public DataLayer.Models.Region ValidateRegion(AdminCreateRequestModel model);
        public BlockRequest ValidateBlockRequest(AdminCreateRequestModel model);
        public AspNetUser ValidateAspNetUser(AdminCreateRequestModel model);
        public void InsertDataOfRequest(AdminCreateRequestModel model);
        public bool VerifyLocation(string state);
        public AspNetUser ValidateAspNetUser(LoginViewModel model);
        public User ValidateUser(LoginViewModel model);
        public User ValidateUserByRequestId(Request r);
        public List<RequestWiseFile> GetFileData(int requestid);
        public Request GetRequestWithUser(int requestid);
        public void AddFile(RequestWiseFile requestWiseFile);
        public AspNetUser ValidAspNetUser(string email);
        public List<HealthProfessional> getBusinessData(int professionId);
        public PasswordReset ValidateToken(string token);
        public AspNetUser ValidateUserForResetPassword(ResetPasswordViewModel model, string useremail);
        public void SetPasswordForResetPassword(AspNetUser user, ResetPasswordViewModel model);
        public List<Request> GetRequestDataInList();
        public int SingleDelete(int id);



    }
}