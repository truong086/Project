/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.controller;

import com.btljava.Service.IBacSiService;
import com.btljava.Service.Impl.BacSiService;
import com.btljava.daos.IBacSi;
import com.btljava.dao.impl.bacsiDao;
import com.btljava.model.bacsi;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class BacSiController {
    private IBacSiService bs;
    
    public BacSiController(){
        bs = new BacSiService();
    }
    
    
    public boolean insert(bacsi nv) throws Exception {
        return bs.insert(nv);
    }

    
    public boolean update(bacsi nv) throws Exception {
        return bs.update(nv);
    }

    
    public boolean updates(bacsi nv) throws Exception {
        return bs.updates(nv);
    }

    
    public boolean delete(String nv) throws Exception {
        return bs.delete(nv);
    }

    
    public boolean deletes(String nv) throws Exception {
        return bs.deletes(nv);
    }

    
    public List<bacsi> fiindAll() throws Exception {
        return bs.fiindAll();
    }

    
    public List<bacsi> timkiem(String s) throws Exception {
        return bs.timkiem(s);
    }

    
    public bacsi findby(String id) throws Exception {
        return bs.findby(id);
    }

    
    public bacsi finbyid(int id) throws Exception {
        return bs.finbyid(id);
    }
}
