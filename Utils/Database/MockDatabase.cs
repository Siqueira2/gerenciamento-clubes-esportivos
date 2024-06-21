using GerenciamentoClubesEsportivos.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GerenciamentoClubesEsportivos.Utils.Database
{
    public class MockDatabase
    {
        private static readonly Lazy<MockDatabase> _instance = new Lazy<MockDatabase>(() => new MockDatabase());

        public static MockDatabase Instance => _instance.Value;

        public List<Member> Members { get; private set; }
        public List<Dependent> Dependents { get; private set; }

        private MockDatabase()
        {
            Members = new List<Member>();
            Dependents = new List<Dependent>();
        }

        private string GenerateId()
        {
            return Guid.NewGuid().ToString().Substring(0, 4);
        }

        public void AddMember(Member member)
        {
            member.Id = GenerateId();
            Members.Add(member);
        }

        public void AddDependent(Dependent dependent)
        {
            dependent.Id = GenerateId();
            Member member = GetMemberById(dependent.MemberId);
            if (member != null)
            {
                member.Dependents.Add(dependent);
            }
            else
            {
                throw new InvalidOperationException("Member not found.");
            }
            Dependents.Add(dependent);
        }

        public void DeleteMember(string id)
        {
            Member member = GetMemberById(id);
            if (member != null)
            {
                Members.Remove(member);
            }
        }

        public List<Dependent> GetDependentsByMemberId(string memberId)
        {
            return Dependents.Where(d => d.MemberId == memberId).ToList();
        }

        public void DeleteDependent(string id)
        {
            Dependent dependent = GetDependentById(id);
            if (dependent != null)
            {
                Dependents.Remove(dependent);
            }
        }

        public Member GetMemberById(string id)
        {
            return Members.FirstOrDefault(m => m.Id == id);
        }

        public void AddAllMembers(List<Member> members)
        {
            Members.AddRange(members);
            List<Dependent> dependents = new List<Dependent>();
            foreach (var member in Members)
            {
                dependents.AddRange(member.Dependents);
            }
            AddAllDependents(dependents);
        }

        public void AddAllDependents(List<Dependent> dependents)
        {
            Dependents.AddRange(dependents);
        }

        public Dependent GetDependentById(string id)
        {
            return Dependents.FirstOrDefault(d => d.Id == id);
        }

        public List<Member> GetMembers()
        {
            return Members;
        }

        public List<Dependent> GetDependents()
        {
            return Dependents;
        }

        public void UpdateDependent(Dependent dependent)
        {
            Dependent existingDependent = GetDependentById(dependent.Id);
            if (existingDependent != null)
            {
                existingDependent.Name = dependent.Name;
                existingDependent.CPF = dependent.CPF;
                existingDependent.Kinship = dependent.Kinship;
                existingDependent.MemberId = dependent.MemberId;
            }
            else
            {
                throw new InvalidOperationException("Dependent not found.");
            }
        }

        public void UpdateMember(Member member)
        {
            Member existingMember = GetMemberById(member.Id);
            if (existingMember != null)
            {
                existingMember.Name = member.Name;
                existingMember.Email = member.Email;
                existingMember.CPF = member.CPF;
                existingMember.CEP = member.CEP;
                existingMember.PhoneNumber = member.PhoneNumber;
                existingMember.MembershipDate = member.MembershipDate;
            }
            else
            {
                throw new InvalidOperationException("Member not found.");
            }
        }
    }
}
