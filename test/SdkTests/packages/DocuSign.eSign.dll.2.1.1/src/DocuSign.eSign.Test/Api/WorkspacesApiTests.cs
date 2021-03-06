/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using DocuSign.eSign.Client;
using DocuSign.eSign.Api;
using DocuSign.eSign.Model;

namespace DocuSign.eSign.Test
{
    /// <summary>
    ///  Class for testing WorkspacesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class WorkspacesApiTests
    {
        private WorkspacesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkspacesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WorkspacesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' WorkspacesApi
            //Assert.IsInstanceOfType(typeof(WorkspacesApi), instance, "instance is a WorkspacesApi");
        }

        
        /// <summary>
        /// Test CreateWorkspace
        /// </summary>
        [Test]
        public void CreateWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //Workspace workspace = null;
            //var response = instance.CreateWorkspace(accountId, workspace);
            //Assert.IsInstanceOf<Workspace> (response, "response is Workspace");
        }
        
        /// <summary>
        /// Test CreateWorkspaceFile
        /// </summary>
        [Test]
        public void CreateWorkspaceFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string folderId = null;
            //string workspaceId = null;
            //var response = instance.CreateWorkspaceFile(accountId, folderId, workspaceId);
            //Assert.IsInstanceOf<WorkspaceItem> (response, "response is WorkspaceItem");
        }
        
        /// <summary>
        /// Test DeleteWorkspace
        /// </summary>
        [Test]
        public void DeleteWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string workspaceId = null;
            //var response = instance.DeleteWorkspace(accountId, workspaceId);
            //Assert.IsInstanceOf<Workspace> (response, "response is Workspace");
        }
        
        /// <summary>
        /// Test DeleteWorkspaceFolderItems
        /// </summary>
        [Test]
        public void DeleteWorkspaceFolderItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string folderId = null;
            //string workspaceId = null;
            //WorkspaceItemList workspaceItemList = null;
            //instance.DeleteWorkspaceFolderItems(accountId, folderId, workspaceId, workspaceItemList);
            
        }
        
        /// <summary>
        /// Test GetWorkspace
        /// </summary>
        [Test]
        public void GetWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string workspaceId = null;
            //var response = instance.GetWorkspace(accountId, workspaceId);
            //Assert.IsInstanceOf<Workspace> (response, "response is Workspace");
        }
        
        /// <summary>
        /// Test GetWorkspaceFile
        /// </summary>
        [Test]
        public void GetWorkspaceFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string fileId = null;
            //string folderId = null;
            //string workspaceId = null;
            //string isDownload = null;
            //string pdfVersion = null;
            //instance.GetWorkspaceFile(accountId, fileId, folderId, workspaceId, isDownload, pdfVersion);
            
        }
        
        /// <summary>
        /// Test ListWorkspaceFilePages
        /// </summary>
        [Test]
        public void ListWorkspaceFilePagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string fileId = null;
            //string folderId = null;
            //string workspaceId = null;
            //string count = null;
            //string dpi = null;
            //string maxHeight = null;
            //string maxWidth = null;
            //string startPosition = null;
            //var response = instance.ListWorkspaceFilePages(accountId, fileId, folderId, workspaceId, count, dpi, maxHeight, maxWidth, startPosition);
            //Assert.IsInstanceOf<PageImages> (response, "response is PageImages");
        }
        
        /// <summary>
        /// Test ListWorkspaceFolderItems
        /// </summary>
        [Test]
        public void ListWorkspaceFolderItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string folderId = null;
            //string workspaceId = null;
            //string count = null;
            //string includeFiles = null;
            //string includeSubFolders = null;
            //string includeThumbnails = null;
            //string includeUserDetail = null;
            //string startPosition = null;
            //string workspaceUserId = null;
            //var response = instance.ListWorkspaceFolderItems(accountId, folderId, workspaceId, count, includeFiles, includeSubFolders, includeThumbnails, includeUserDetail, startPosition, workspaceUserId);
            //Assert.IsInstanceOf<WorkspaceFolderContents> (response, "response is WorkspaceFolderContents");
        }
        
        /// <summary>
        /// Test ListWorkspaces
        /// </summary>
        [Test]
        public void ListWorkspacesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //var response = instance.ListWorkspaces(accountId);
            //Assert.IsInstanceOf<WorkspaceList> (response, "response is WorkspaceList");
        }
        
        /// <summary>
        /// Test UpdateWorkspace
        /// </summary>
        [Test]
        public void UpdateWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string workspaceId = null;
            //Workspace workspace = null;
            //var response = instance.UpdateWorkspace(accountId, workspaceId, workspace);
            //Assert.IsInstanceOf<Workspace> (response, "response is Workspace");
        }
        
        /// <summary>
        /// Test UpdateWorkspaceFile
        /// </summary>
        [Test]
        public void UpdateWorkspaceFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string fileId = null;
            //string folderId = null;
            //string workspaceId = null;
            //var response = instance.UpdateWorkspaceFile(accountId, fileId, folderId, workspaceId);
            //Assert.IsInstanceOf<WorkspaceItem> (response, "response is WorkspaceItem");
        }
        
    }

}
