/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.controller;

import com.btljava.Service.INhanVienService;
import com.btljava.Service.Impl.NhanVienService;
import com.btljava.daos.INhanVien;
import com.btljava.dao.impl.nhanvienDao;
import com.btljava.model.nhanvien;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class NhanVienController {
    private INhanVienService dao;
    
    public NhanVienController(){
        dao = new NhanVienService();
    }
    
    public boolean insert(nhanvien nv) throws Exception {
        return dao.insert(nv);
    }

    
    public boolean update(nhanvien nv) throws Exception {
        return dao.update(nv);
    }

    
    public boolean updates(nhanvien nv) throws Exception {
        return dao.updates(nv);
    }

    
    public boolean delete(String nv) throws Exception {
        return dao.delete(nv);
    }

    
    public boolean deletes(String nv) throws Exception {
        return dao.deletes(nv);
    }

    
    public List<nhanvien> fiindAll() throws Exception {
        return dao.fiindAll();
    }

    
    public List<nhanvien> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }

    
    public nhanvien findby(String id) throws Exception {
        return dao.findby(id);
    }

    
    public nhanvien finbyid(int id) throws Exception {
        return dao.finbyid(id);
    }
    
    public List<nhanvien> chucvu(int chucvu) throws Exception{
        return dao.chucvu(chucvu);
    }
}
