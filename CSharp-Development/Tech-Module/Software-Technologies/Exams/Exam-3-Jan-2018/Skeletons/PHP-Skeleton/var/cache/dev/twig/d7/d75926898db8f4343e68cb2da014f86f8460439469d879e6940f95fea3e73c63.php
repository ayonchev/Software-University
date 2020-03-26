<?php

/* project/edit.html.twig */
class __TwigTemplate_f87bd5160ece83d12b7f4659cc2b9f9000fb392b743a79100d9e32743f557ed4 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "project/edit.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_85005cec97d88d5eaf1152591e2dcd0f029e10f124fd449a8faa90101bf24174 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_85005cec97d88d5eaf1152591e2dcd0f029e10f124fd449a8faa90101bf24174->enter($__internal_85005cec97d88d5eaf1152591e2dcd0f029e10f124fd449a8faa90101bf24174_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/edit.html.twig"));

        $__internal_e7e6894906775e09ca045ceefd788b6915e37bcf869bade869c12f05c5532f7d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e7e6894906775e09ca045ceefd788b6915e37bcf869bade869c12f05c5532f7d->enter($__internal_e7e6894906775e09ca045ceefd788b6915e37bcf869bade869c12f05c5532f7d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/edit.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_85005cec97d88d5eaf1152591e2dcd0f029e10f124fd449a8faa90101bf24174->leave($__internal_85005cec97d88d5eaf1152591e2dcd0f029e10f124fd449a8faa90101bf24174_prof);

        
        $__internal_e7e6894906775e09ca045ceefd788b6915e37bcf869bade869c12f05c5532f7d->leave($__internal_e7e6894906775e09ca045ceefd788b6915e37bcf869bade869c12f05c5532f7d_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_7296f5326f0f717f015b13fabc2f428afecb8a740e6afd368b6caeb23c7b530f = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_7296f5326f0f717f015b13fabc2f428afecb8a740e6afd368b6caeb23c7b530f->enter($__internal_7296f5326f0f717f015b13fabc2f428afecb8a740e6afd368b6caeb23c7b530f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_75f660c78a37d4ae2f70125c2fbd8a9d99d1b54c3383d1a8df192248826c0b6b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_75f660c78a37d4ae2f70125c2fbd8a9d99d1b54c3383d1a8df192248826c0b6b->enter($__internal_75f660c78a37d4ae2f70125c2fbd8a9d99d1b54c3383d1a8df192248826c0b6b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Delete Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" value=\"";
        // line 11
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "title", array()), "html", null, true);
        echo "\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\">";
        // line 15
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "description", array()), "html", null, true);
        echo "</textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" value=\"";
        // line 19
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "budget", array()), "html", null, true);
        echo "\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Edit Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        ";
        // line 26
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "
    </form>
</div>
";
        
        $__internal_75f660c78a37d4ae2f70125c2fbd8a9d99d1b54c3383d1a8df192248826c0b6b->leave($__internal_75f660c78a37d4ae2f70125c2fbd8a9d99d1b54c3383d1a8df192248826c0b6b_prof);

        
        $__internal_7296f5326f0f717f015b13fabc2f428afecb8a740e6afd368b6caeb23c7b530f->leave($__internal_7296f5326f0f717f015b13fabc2f428afecb8a740e6afd368b6caeb23c7b530f_prof);

    }

    public function getTemplateName()
    {
        return "project/edit.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  82 => 26,  72 => 19,  65 => 15,  58 => 11,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Delete Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" value=\"{{ project.title }}\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\">{{ project.description }}</textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" value=\"{{ project.budget }}\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Edit Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        {{ form_row(form._token) }}
    </form>
</div>
{% endblock %}

", "project/edit.html.twig", "C:\\Projects\\Software-Technologies\\Exam-3-Jan-2018\\Skeletons\\PHP-Skeleton\\app\\Resources\\views\\project\\edit.html.twig");
    }
}
