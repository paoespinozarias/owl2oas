﻿using System;

namespace OWL2OAS.VocabularyHelper
{
    public static class O2O
    {
        public static readonly Uri included = new Uri("https://karlhammar.com/owl2oas/o2o.owl#included");
        public static readonly Uri endpoint = new Uri("https://karlhammar.com/owl2oas/o2o.owl#endpoint");
    }

    public static class DC
    {
        public static readonly Uri title = new Uri("http://purl.org/dc/elements/1.1/title");
        public static readonly Uri description = new Uri("http://purl.org/dc/elements/1.1/description");
    }

    public static class CC
    {
        public static readonly Uri license = new Uri("http://creativecommons.org/ns#license");
    }

    public static class RDFS
    {
        public static readonly Uri label = new Uri("http://www.w3.org/2000/01/rdf-schema#label");
        public static readonly Uri Datatype = new Uri("http://www.w3.org/2000/01/rdf-schema#Datatype");
    }

    public static class OWL
    {
        public static readonly Uri Thing = new Uri("http://www.w3.org/2002/07/owl#Thing");
        public static readonly Uri Restriction = new Uri("http://www.w3.org/2002/07/owl#Restriction");
        public static readonly Uri FunctionalProperty = new Uri("http://www.w3.org/2002/07/owl#FunctionalProperty");
        public static readonly Uri versionIRI = new Uri("http://www.w3.org/2002/07/owl#versionIRI");
        public static readonly Uri deprecated = new Uri("http://www.w3.org/2002/07/owl#deprecated");

        #region Restrictions
        public static readonly Uri onProperty = new Uri("http://www.w3.org/2002/07/owl#onProperty");
        public static readonly Uri onClass = new Uri("http://www.w3.org/2002/07/owl#onClass");
        public static readonly Uri cardinality = new Uri("http://www.w3.org/2002/07/owl#cardinality");
        public static readonly Uri qualifiedCardinality = new Uri("http://www.w3.org/2002/07/owl#qualifiedCardinality");
        public static readonly Uri someValuesFrom = new Uri("http://www.w3.org/2002/07/owl#someValuesFrom");
        public static readonly Uri minCardinality = new Uri("http://www.w3.org/2002/07/owl#minCardinality");
        public static readonly Uri minQualifiedCardinality = new Uri("http://www.w3.org/2002/07/owl#minQualifiedCardinality");
        public static readonly Uri maxCardinality = new Uri("http://www.w3.org/2002/07/owl#maxCardinality");
        public static readonly Uri maxQualifiedCardinality = new Uri("http://www.w3.org/2002/07/owl#maxQualifiedCardinality");
        #endregion
    }
}
