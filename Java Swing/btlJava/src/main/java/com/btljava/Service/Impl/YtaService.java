/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service.Impl;

import com.btljava.Service.IYtaService;
import com.btljava.daos.IYta;
import com.btljava.dao.impl.ytaDao;
import com.btljava.model.yta;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class YtaService implements IYtaService{
    
    private IYta dao;
    
    public YtaService(){
        dao = new ytaDao();
    }
    
    @Override
    public boolean insert(yta nv) throws Exception {
        return dao.insert(nv);
    }

    @Override
    public boolean update(yta nv) throws Exception {
        return dao.update(nv);
    }

    @Override
    public boolean updates(yta nv) throws Exception {
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
    public List<yta> fiindAll() throws Exception {
        return dao.fiindAll();
    }

    @Override
    public List<yta> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }

    @Override
    public yta findby(String id) throws Exception {
        return dao.findby(id);
    }

    @Override
    public yta finbyid(int id) throws Exception {
        return dao.finbyid(id);
    }
    
}
