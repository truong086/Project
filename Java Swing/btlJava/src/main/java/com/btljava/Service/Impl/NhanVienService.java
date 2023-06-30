/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service.Impl;

import com.btljava.Service.INhanVienService;
import com.btljava.daos.INhanVien;
import com.btljava.dao.impl.nhanvienDao;
import com.btljava.model.nhanvien;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class NhanVienService implements INhanVienService{
    private INhanVien dao;
    
    public NhanVienService(){
        dao = new nhanvienDao();
    }
    @Override
    public boolean insert(nhanvien nv) throws Exception {
        return dao.insert(nv);
    }

    @Override
    public boolean update(nhanvien nv) throws Exception {
        return dao.update(nv);
    }

    @Override
    public boolean updates(nhanvien nv) throws Exception {
        return dao.updates(nv);
    }

    @Override
    public boolean delete(String nv) throws Exception {
        return dao.delete(nv);
    }

    @Override
    public boolean deletes(String nv) throws Exception {
        return dao.deletes(nv);
    }

    @Override
    public List<nhanvien> fiindAll() throws Exception {
        return dao.fiindAll();
    }

    @Override
    public List<nhanvien> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }

    @Override
    public nhanvien findby(String id) throws Exception {
        return dao.findby(id);
    }

    @Override
    public nhanvien finbyid(int id) throws Exception {
        return dao.finbyid(id);
    }

    @Override
    public List<nhanvien> chucvu(int chucvu) throws Exception {
        return dao.chucvu(chucvu);
    }
    
}
