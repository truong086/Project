/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.controller;

import com.btljava.Service.IYtaService;
import com.btljava.Service.Impl.YtaService;
import com.btljava.daos.IYta;
import com.btljava.dao.impl.ytaDao;
import com.btljava.model.yta;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class YtaController {
    private IYtaService dao;
    
    public YtaController(){
        dao = new YtaService();
    }
    
    
    public boolean insert(yta nv) throws Exception {
        return dao.insert(nv);
    }

    
    public boolean update(yta nv) throws Exception {
        return dao.update(nv);
    }

    
    public boolean updates(yta nv) throws Exception {
        return dao.updates(nv);
    }

    
    public boolean delete(String nv) throws Exception {
        return dao.delete(nv);
    }

    
    public boolean deletes(String nv) throws Exception {
        return dao.deletes(nv);
    }

    
    public List<yta> fiindAll() throws Exception {
        return dao.fiindAll();
    }

    
    public List<yta> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }

    
    public yta findby(String id) throws Exception {
        return dao.findby(id);
    }

    
    public yta finbyid(int id) throws Exception {
        return dao.finbyid(id);
    }
}
