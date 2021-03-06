<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_09886c37796d81d574b2448cf2a22ea32da8dad546b69f22c376ce19a869ce97 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_33e0a7294034873ea6927c14dd5b8d1c4903723d9979f04d195aec42b3aaa10c = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_33e0a7294034873ea6927c14dd5b8d1c4903723d9979f04d195aec42b3aaa10c->enter($__internal_33e0a7294034873ea6927c14dd5b8d1c4903723d9979f04d195aec42b3aaa10c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $__internal_3a586a87c0bafe55123bc6d7c667e9dd6e4883230d6bb4796f6aa4aff7f0c843 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_3a586a87c0bafe55123bc6d7c667e9dd6e4883230d6bb4796f6aa4aff7f0c843->enter($__internal_3a586a87c0bafe55123bc6d7c667e9dd6e4883230d6bb4796f6aa4aff7f0c843_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_33e0a7294034873ea6927c14dd5b8d1c4903723d9979f04d195aec42b3aaa10c->leave($__internal_33e0a7294034873ea6927c14dd5b8d1c4903723d9979f04d195aec42b3aaa10c_prof);

        
        $__internal_3a586a87c0bafe55123bc6d7c667e9dd6e4883230d6bb4796f6aa4aff7f0c843->leave($__internal_3a586a87c0bafe55123bc6d7c667e9dd6e4883230d6bb4796f6aa4aff7f0c843_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_28c72be1c5463be628c024867adce1028241e97d192ac473b24fc1cb009781bc = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_28c72be1c5463be628c024867adce1028241e97d192ac473b24fc1cb009781bc->enter($__internal_28c72be1c5463be628c024867adce1028241e97d192ac473b24fc1cb009781bc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        $__internal_7ba9dc4049465cf3366df2b3fba534ee8c8a3366eab2c0728921c5dd64eb4e4a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_7ba9dc4049465cf3366df2b3fba534ee8c8a3366eab2c0728921c5dd64eb4e4a->enter($__internal_7ba9dc4049465cf3366df2b3fba534ee8c8a3366eab2c0728921c5dd64eb4e4a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_7ba9dc4049465cf3366df2b3fba534ee8c8a3366eab2c0728921c5dd64eb4e4a->leave($__internal_7ba9dc4049465cf3366df2b3fba534ee8c8a3366eab2c0728921c5dd64eb4e4a_prof);

        
        $__internal_28c72be1c5463be628c024867adce1028241e97d192ac473b24fc1cb009781bc->leave($__internal_28c72be1c5463be628c024867adce1028241e97d192ac473b24fc1cb009781bc_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_788e059bc4d309d02f1edc340696087e20f896b1b69d4ed7b15b8905b5852a18 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_788e059bc4d309d02f1edc340696087e20f896b1b69d4ed7b15b8905b5852a18->enter($__internal_788e059bc4d309d02f1edc340696087e20f896b1b69d4ed7b15b8905b5852a18_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_520afcff505b81d9f960ebe89037c46e82d68094b8daee71eef12d3911695dae = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_520afcff505b81d9f960ebe89037c46e82d68094b8daee71eef12d3911695dae->enter($__internal_520afcff505b81d9f960ebe89037c46e82d68094b8daee71eef12d3911695dae_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_520afcff505b81d9f960ebe89037c46e82d68094b8daee71eef12d3911695dae->leave($__internal_520afcff505b81d9f960ebe89037c46e82d68094b8daee71eef12d3911695dae_prof);

        
        $__internal_788e059bc4d309d02f1edc340696087e20f896b1b69d4ed7b15b8905b5852a18->leave($__internal_788e059bc4d309d02f1edc340696087e20f896b1b69d4ed7b15b8905b5852a18_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_b84962f45479f4f123e5284333d2f66089c6b75fb837c322b68214d0d48efe45 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_b84962f45479f4f123e5284333d2f66089c6b75fb837c322b68214d0d48efe45->enter($__internal_b84962f45479f4f123e5284333d2f66089c6b75fb837c322b68214d0d48efe45_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_22e1d6e20d31c998775abf0d26182c05076ef7fe870bae774c0504a131ee3b74 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_22e1d6e20d31c998775abf0d26182c05076ef7fe870bae774c0504a131ee3b74->enter($__internal_22e1d6e20d31c998775abf0d26182c05076ef7fe870bae774c0504a131ee3b74_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_22e1d6e20d31c998775abf0d26182c05076ef7fe870bae774c0504a131ee3b74->leave($__internal_22e1d6e20d31c998775abf0d26182c05076ef7fe870bae774c0504a131ee3b74_prof);

        
        $__internal_b84962f45479f4f123e5284333d2f66089c6b75fb837c322b68214d0d48efe45->leave($__internal_b84962f45479f4f123e5284333d2f66089c6b75fb837c322b68214d0d48efe45_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  94 => 13,  85 => 12,  71 => 7,  68 => 6,  59 => 5,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
", "@WebProfiler/Collector/router.html.twig", "C:\\Projects\\Software-Technologies\\Exam-3-Jan-2018\\Skeletons\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\router.html.twig");
    }
}
