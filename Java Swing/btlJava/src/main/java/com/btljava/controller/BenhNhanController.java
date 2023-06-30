/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.controller;

import com.btljava.Service.IBenhNhanService;
import com.btljava.Service.Impl.BenhNhanService;
import com.btljava.daos.IBenhNhan;
import com.btljava.dao.impl.benhnhanDao;
import com.btljava.model.benhnhan;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class BenhNhanController {
    private IBenhNhanService dao;
    
    public BenhNhanController(){
        dao = new BenhNhanService();
    }
    
    
  
    public boolean insert(benhnhan bv) throws Exception {
        return dao.insert(bv);
    }

    public boolean update(benhnhan bv) throws Exception {
        return dao.update(bv);
    }

   
    public boolean updates(benhnhan bv) throws Exception {
        return dao.update(bv);
    }

    
    public boolean delete(String bv) throws Exception {
        return dao.delete(bv);
    }

    
    public boolean deletes(String bv) throws Exception {
        return dao.deletes(bv);
    }

    
    public List<benhnhan> findAll() throws Exception {
        return dao.findAll();
    }

    
    public List<benhnhan> banhnhancovid19() throws Exception {
        return dao.banhnhancovid19();
    }

    
    public List<benhnhan> chuathanhtoan() throws Exception {
        return dao.chuathanhtoan();
    }

    
    public List<benhnhan> benhnhandacbiet() throws Exception {
        return dao.benhnhandacbiet();
    }

    
    public List<benhnhan> benhdichuyen() throws Exception {
        return dao.benhdichuyen();
    }

    
    public List<benhnhan> benhhiemgap() throws Exception {
        return dao.benhhiemgap();
    }

    
    public List<benhnhan> timkiem(String s) throws Exception {
       return dao.timkiem(s);
    }

    
    public benhnhan findbyid(int n) throws Exception {
        return dao.findbyid(n);
    }

    
    public benhnhan findby(String s) throws Exception {
        return dao.findby(s);
    }
}
